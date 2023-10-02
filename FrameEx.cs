using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using MediaInfo;


namespace FrameEx
{
    public partial class FrameEx : Form
    {
        string ffmpegPath;
        string inputVideoPath = "";
        string outputFolder = "";
        string duration = "";
        string videoName = "";
        string outputFormat = "jpg";
        string outputPath = "";
        double totalDurationInSeconds;
        int extractionSeconds;
        double fps;
        double numberOfFramesForExtraction;
        private Process extractionProc = null;

        public FrameEx()
        {
            InitializeComponent();
            // Select jpg as default output format
            formatPicker.SelectedIndex = 0;
            // Subscribe to the FormClosing event
            this.FormClosing += FrameExFormClosing;
            // Set path to ffmpeg-a
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            ffmpegPath = Path.Combine(baseDirectory, "ffmpeg.exe");
        }
        private void BrowseVideoBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Video Files|*.mp4;*.m4v;*.mov;*.avi;*.mkv;*.wmv|All Files|*.*";
                openFileDialog.Title = "Select a Video File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save path
                    inputVideoPath = openFileDialog.FileName;
                    selectVideoTxtbox.Text = inputVideoPath;
                    // For output filename formating
                    videoName = Path.GetFileNameWithoutExtension(inputVideoPath);

                    // Get video duration using ffmpeg
                    Process getVideoDuration = new Process();
                    getVideoDuration.StartInfo.FileName = ffmpegPath;
                    getVideoDuration.StartInfo.Arguments = $"-i \"{inputVideoPath}\"";
                    getVideoDuration.StartInfo.UseShellExecute = false;
                    getVideoDuration.StartInfo.RedirectStandardError = true;
                    getVideoDuration.StartInfo.CreateNoWindow = true;
                    getVideoDuration.Start();
                    string getVideoDurationOutput = getVideoDuration.StandardError.ReadToEnd();
                    getVideoDuration.WaitForExit();

                    // Parse the FFmpeg output to extract the video duration
                    if (!string.IsNullOrEmpty(getVideoDurationOutput))
                    {
                        int index = getVideoDurationOutput.IndexOf("Duration: ");
                        if (index >= 0)
                        {
                            string durationString = getVideoDurationOutput.Substring(index + 10, 12);
                            duration = durationString.Replace(",", "");
                        }
                    }
                    // Convert the duration string to a TimeSpan
                    if (TimeSpan.TryParse(duration, out TimeSpan videoDuration))
                    {
                        // FFmpeg rounds down video length if there's 0 in the first decimal place when extracting frames
                        string totalDurationInSecondsTest = videoDuration.TotalSeconds.ToString(); // Convert the number to a string
                        int decimalPointIndexDur = totalDurationInSecondsTest.IndexOf('.');
                        if (decimalPointIndexDur != -1 && decimalPointIndexDur + 1 < totalDurationInSecondsTest.Length && totalDurationInSecondsTest[decimalPointIndexDur + 1] == '0')
                        {
                            totalDurationInSeconds = Math.Floor(videoDuration.TotalSeconds);
                        }
                        else
                        {
                            totalDurationInSeconds = videoDuration.TotalSeconds;
                        }
                        // Set trackBar size
                        trackBar.Maximum = (int)totalDurationInSeconds;
                        // Duration of a video is set as last frames initial location, set Last frame maximum, restart First frame value
                        lastFrameTimestampUpDown.Maximum = (decimal)totalDurationInSeconds;
                        lastFrameTimestampUpDown.Value = lastFrameTimestampUpDown.Maximum;
                        lastFrameTimestampUpDown.Value = lastFrameTimestampUpDown.Maximum;
                        firstFrameTimestampUpDown.Value = 0;
                    }
                    // Get video fps
                    var media = new MediaInfoWrapper(inputVideoPath);
                    fps = media.Framerate;
                    // FFmpeg rounds down FPS if there's 0 on the first decimal place and rounds up for every other case when extracting frames
                    string fpsTest = fps.ToString(); // Convert the number to a string
                    int decimalPointIndexFps = fpsTest.IndexOf('.');
                    if (decimalPointIndexFps != -1 && decimalPointIndexFps + 1 < fpsTest.Length && fpsTest[decimalPointIndexFps + 1] == '0') {
                        fps = Math.Floor(fps);
                    }
                    else {
                        fps = Math.Ceiling(fps);
                    }
                    // Enable Buttons for frame searching
                    EnableButtonForFrameSeaching();
                    // Enable Extract button if you already have outputPath selected
                    if (outputFolder != "")
                    {
                        extractBtn.Enabled = true;
                        // Create outputPath with videoName
                        outputPath = Path.Combine(outputFolder, videoName + "-%d." + outputFormat);
                        // Enable format picker
                        formatPicker.Enabled = true;
                    }
                }
            }

        }

        private void BrowseFolderBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select output Folder";
                folderBrowserDialog.SelectedPath = Directory.GetCurrentDirectory();

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    outputFolder = folderBrowserDialog.SelectedPath;
                    outputFolderTxtbox.Text = outputFolder;
                    // Enable Extract button if you already have inputVideo selected
                    if (inputVideoPath != "")
                    {
                        extractBtn.Enabled = true;
                        // Create outputPath with videoName
                        outputPath = Path.Combine(outputFolder, videoName + "-%d." + outputFormat);
                        // Enable format picker
                        formatPicker.Enabled = true;
                    }
                }
            }
        }

        private void ExtractBtn_Click(object sender, EventArgs e)
        {
            // Calculate last frame timestamp
            extractionSeconds = (int)lastFrameTimestampUpDown.Value - (int)firstFrameTimestampUpDown.Value;
            // Calculate number of frames for extraction
            numberOfFramesForExtraction = Math.Ceiling(extractionSeconds * fps);
            Console.WriteLine($"Number of frames for extraction: {numberOfFramesForExtraction}");
            // Convert the numeric value to a TimeSpan
            TimeSpan extractionTime = TimeSpan.FromSeconds(extractionSeconds);
            // Format the TimeSpan as "hh:mm:ss"
            string extractionFormattedTime = string.Format("{0:D2}:{1:D2}:{2:D2}", extractionTime.Hours, extractionTime.Minutes, extractionTime.Seconds);
            // Build the FFmpeg command
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = ffmpegPath,
                Arguments = $"-ss \"{firstFrameTimestamp.Text}\" -i \"{inputVideoPath}\" -t \"{extractionFormattedTime}\" -q:v 1 \"{outputPath}", //-q:v specifies the quality level of the output image, which ranges from 1 (highest quality) to 31 (lowest quality)
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardError = true
            };
            extractionProc = System.Diagnostics.Process.Start(startInfo);
            extractionProc.EnableRaisingEvents = true; // Enables the Exited event
            extractionProc.ErrorDataReceived += ExtractionProcErrorDataReceived;
            extractionProc.BeginErrorReadLine();
            // UI UPDATE
            extractBtn.Enabled = false;
            selectVideoBtn.Enabled = false;
            outputFolderBtn.Enabled = false;
            trackBar.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            stopBtn.Enabled = true;
            progressBar.Value = 0;
            // Disable Buttons for frame searching
            firstFrameTimestampUpDown.Enabled = false;
            lastFrameTimestampUpDown.Enabled = false;
            startVideoTimestampBtn.Enabled = false;
            endVideoTimestampBtn.Enabled = false;
            progressLabel.Text = "In progress...";
            // Handle the Exited event to know when FFmpeg has finished
            extractionProc.Exited += (exitSender, exitE) =>
            {
                // Check the ExitCode to determine the result of the process
                int exitCode = extractionProc.ExitCode;
                if (exitCode == 0)
                {
                    progressBar.Invoke((MethodInvoker)delegate
                    {
                        progressBar.Value = 100;
                        progressLabel.Text = "Done";
                        stopBtn.Enabled = false;
                        extractBtn.Enabled = true;
                        selectVideoBtn.Enabled = true;
                        outputFolderBtn.Enabled = true;
                        // enable Buttons for frame searching
                        EnableButtonForFrameSeaching();
                    });
                    MessageBox.Show("Conversion complete!"); // User feedback
                }
                else
                {
                    Console.WriteLine($"FFmpeg process exited with error code: {exitCode}");
                }
                // Dispose of the process
                extractionProc.Dispose();
            };
        }
        void ExtractionProcErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null && e.Data.StartsWith("frame="))
            {
                //extract from ffmpeg last extracted frame
                string input = e.Data.Split('=')[1].Trim();
                string trimInput = input.Replace(" fps", "");
                int lastFrame = Int32.Parse(trimInput);
                // progress  bar update
                progressBar.Invoke((MethodInvoker)delegate {
                    double progressBarVal = lastFrame / numberOfFramesForExtraction * 100;
                    if (progressBarVal < 100) progressBar.Value = (int)progressBarVal;
                });
            }
        }
        private void StopBtn_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                extractionProc.Kill();
                // restart UI
                progressLabel.Text = "";
                progressBar.Value = 0;
                stopBtn.Enabled = false;
                extractBtn.Enabled = true;
                selectVideoBtn.Enabled = true;
                outputFolderBtn.Enabled = true;
                // enable Buttons for frame searching
                EnableButtonForFrameSeaching();
                MessageBox.Show("Conversion aborted!");            }
        }

        private void FrameExFormClosing(object sender, EventArgs e)
        {
            if (extractionProc != null)
            {
                try
                {
                    // kill process if running at exit
                    Process[] processes = Process.GetProcessesByName(extractionProc.ProcessName);
                    if (processes.Length > 0)   extractionProc.Kill();
                }
                catch (Exception ex)
                {
                    // Handle any exceptions gracefully
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
        private void FirstFrameTimestampUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Set maximum limit
            firstFrameTimestampUpDown.Maximum = lastFrameTimestampUpDown.Value - 1;
            lastFrameTimestampUpDown.Minimum = firstFrameTimestampUpDown.Value + 1;
            // Get the numeric value from the NumericUpDown control
            int seconds = (int)firstFrameTimestampUpDown.Value;
            // Convert the numeric value to a TimeSpan
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            // Format the TimeSpan as "hh:mm:ss"
            string formattedTime = string.Format("{0:D2}:{1:D2}:{2:D2}", time.Hours, time.Minutes, time.Seconds);
            // Update the display
            firstFrameTimestamp.Text = formattedTime;
            // Update trackBar
            if (radioButton1.Checked == true)
            {
                trackBar.Value = seconds;
            }
        }
        private void LastFrameTimestampUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Set minimum limit
            lastFrameTimestampUpDown.Minimum = firstFrameTimestampUpDown.Value + 1;
            firstFrameTimestampUpDown.Maximum = lastFrameTimestampUpDown.Value - 1;
            // Get the numeric value from the NumericUpDown control
            int seconds = (int)lastFrameTimestampUpDown.Value;
            // Convert the numeric value to a TimeSpan
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            // Format the TimeSpan as "hh:mm:ss"
            string formattedTime = string.Format("{0:D2}:{1:D2}:{2:D2}", time.Hours, time.Minutes, time.Seconds);
            // Update the display
            lastFrameTimestamp.Text = formattedTime;
            // Update trackBar
            if (radioButton2.Checked == true)
            {
                trackBar.Value = seconds;
            }
        }
        // restart 1st frame btn
        private void StartVideoTimestampBtn_Click(object sender, EventArgs e)
        {
            firstFrameTimestampUpDown.Value = 0;
            firstFrameTimestampUpDown.DownButton();
        }

        // restart last frame btn
        private void EndVideoTimestampBtn_Click(object sender, EventArgs e)
        {
            lastFrameTimestampUpDown.Value = (decimal)totalDurationInSeconds;
            lastFrameTimestampUpDown.UpButton();
        }

        private void formatPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formatPicker.SelectedItem == null)
            {
                return;
            }
            outputFormat = formatPicker.SelectedItem.ToString();
            // Create outputPath with videoName
            outputPath = Path.Combine(outputFolder, videoName + "-%d." + outputFormat);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // move trackBar possition
            trackBar.Value = (int)firstFrameTimestampUpDown.Value;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // move trackBar possition
            trackBar.Value = (int)lastFrameTimestampUpDown.Value;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            // move firstFrameTimestamp
            if (radioButton1.Checked == true)
            {
                // maximum limmit
                if (trackBar.Value > (int)firstFrameTimestampUpDown.Maximum)
                {
                    trackBar.Value = (int)firstFrameTimestampUpDown.Maximum;
                }
                else
                {
                    firstFrameTimestampUpDown.Value = trackBar.Value;
                }
            }
            // move lastFrameTimestamp
            else
            {   
                // minimum limmit
                if (trackBar.Value < (int)lastFrameTimestampUpDown.Minimum)
                {
                    trackBar.Value = (int)lastFrameTimestampUpDown.Minimum;
                }
                else
                {
                    lastFrameTimestampUpDown.Value = trackBar.Value;
                }
            }

        }
        private void EnableButtonForFrameSeaching()
        {
            firstFrameTimestampUpDown.Enabled = true;
            lastFrameTimestampUpDown.Enabled = true;
            startVideoTimestampBtn.Enabled = true;
            endVideoTimestampBtn.Enabled = true;
            trackBar.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
        }
    }
}
