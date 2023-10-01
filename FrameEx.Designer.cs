namespace FrameEx
{
    partial class FrameEx
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameEx));
            this.selectVideoBtn = new System.Windows.Forms.Button();
            this.selectVideoLbl = new System.Windows.Forms.Label();
            this.outputFolderLbl = new System.Windows.Forms.Label();
            this.outputFolderBtn = new System.Windows.Forms.Button();
            this.selectVideoTxtbox = new System.Windows.Forms.TextBox();
            this.outputFolderTxtbox = new System.Windows.Forms.TextBox();
            this.extractBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.stopBtn = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.firstFramelbl = new System.Windows.Forms.Label();
            this.lastFrameLbl = new System.Windows.Forms.Label();
            this.firstFrameTimestampUpDown = new System.Windows.Forms.NumericUpDown();
            this.firstFrameTimestamp = new System.Windows.Forms.TextBox();
            this.lastFrameTimestampUpDown = new System.Windows.Forms.NumericUpDown();
            this.lastFrameTimestamp = new System.Windows.Forms.TextBox();
            this.endVideoTimestampBtn = new System.Windows.Forms.PictureBox();
            this.startVideoTimestampBtn = new System.Windows.Forms.PictureBox();
            this.formatPicker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.firstFrameTimestampUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastFrameTimestampUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endVideoTimestampBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startVideoTimestampBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // selectVideoBtn
            // 
            this.selectVideoBtn.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectVideoBtn.Location = new System.Drawing.Point(214, 78);
            this.selectVideoBtn.Name = "selectVideoBtn";
            this.selectVideoBtn.Size = new System.Drawing.Size(112, 33);
            this.selectVideoBtn.TabIndex = 0;
            this.selectVideoBtn.Text = "Browse";
            this.selectVideoBtn.UseVisualStyleBackColor = true;
            this.selectVideoBtn.Click += new System.EventHandler(this.BrowseVideoBtn_Click);
            // 
            // selectVideoLbl
            // 
            this.selectVideoLbl.AutoSize = true;
            this.selectVideoLbl.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectVideoLbl.Location = new System.Drawing.Point(28, 18);
            this.selectVideoLbl.Name = "selectVideoLbl";
            this.selectVideoLbl.Size = new System.Drawing.Size(284, 20);
            this.selectVideoLbl.TabIndex = 1;
            this.selectVideoLbl.Text = "Select the video for frame extraction";
            this.selectVideoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputFolderLbl
            // 
            this.outputFolderLbl.AutoSize = true;
            this.outputFolderLbl.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputFolderLbl.Location = new System.Drawing.Point(28, 117);
            this.outputFolderLbl.Name = "outputFolderLbl";
            this.outputFolderLbl.Size = new System.Drawing.Size(159, 20);
            this.outputFolderLbl.TabIndex = 2;
            this.outputFolderLbl.Text = "Select output folder";
            this.outputFolderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputFolderBtn
            // 
            this.outputFolderBtn.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputFolderBtn.Location = new System.Drawing.Point(214, 177);
            this.outputFolderBtn.Name = "outputFolderBtn";
            this.outputFolderBtn.Size = new System.Drawing.Size(112, 33);
            this.outputFolderBtn.TabIndex = 3;
            this.outputFolderBtn.Text = "Browse";
            this.outputFolderBtn.UseVisualStyleBackColor = true;
            this.outputFolderBtn.Click += new System.EventHandler(this.BrowseFolderBtn_Click);
            // 
            // selectVideoTxtbox
            // 
            this.selectVideoTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectVideoTxtbox.Location = new System.Drawing.Point(32, 45);
            this.selectVideoTxtbox.Name = "selectVideoTxtbox";
            this.selectVideoTxtbox.ReadOnly = true;
            this.selectVideoTxtbox.Size = new System.Drawing.Size(483, 24);
            this.selectVideoTxtbox.TabIndex = 4;
            // 
            // outputFolderTxtbox
            // 
            this.outputFolderTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputFolderTxtbox.Location = new System.Drawing.Point(32, 144);
            this.outputFolderTxtbox.Name = "outputFolderTxtbox";
            this.outputFolderTxtbox.ReadOnly = true;
            this.outputFolderTxtbox.Size = new System.Drawing.Size(483, 24);
            this.outputFolderTxtbox.TabIndex = 5;
            // 
            // extractBtn
            // 
            this.extractBtn.BackColor = System.Drawing.Color.Lime;
            this.extractBtn.Enabled = false;
            this.extractBtn.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extractBtn.Location = new System.Drawing.Point(214, 376);
            this.extractBtn.Name = "extractBtn";
            this.extractBtn.Size = new System.Drawing.Size(112, 42);
            this.extractBtn.TabIndex = 6;
            this.extractBtn.Text = "EXTRACT";
            this.extractBtn.UseVisualStyleBackColor = false;
            this.extractBtn.Click += new System.EventHandler(this.ExtractBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(32, 429);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(483, 30);
            this.progressBar.TabIndex = 7;
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(214, 470);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(112, 33);
            this.stopBtn.TabIndex = 8;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.BackColor = System.Drawing.SystemColors.Control;
            this.progressLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressLabel.Location = new System.Drawing.Point(56, 352);
            this.progressLabel.MinimumSize = new System.Drawing.Size(100, 20);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(100, 20);
            this.progressLabel.TabIndex = 9;
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstFramelbl
            // 
            this.firstFramelbl.AutoSize = true;
            this.firstFramelbl.Location = new System.Drawing.Point(91, 229);
            this.firstFramelbl.Name = "firstFramelbl";
            this.firstFramelbl.Size = new System.Drawing.Size(152, 17);
            this.firstFramelbl.TabIndex = 10;
            this.firstFramelbl.Text = "First Frame Timestamp";
            // 
            // lastFrameLbl
            // 
            this.lastFrameLbl.AutoSize = true;
            this.lastFrameLbl.Location = new System.Drawing.Point(296, 229);
            this.lastFrameLbl.Name = "lastFrameLbl";
            this.lastFrameLbl.Size = new System.Drawing.Size(152, 17);
            this.lastFrameLbl.TabIndex = 10;
            this.lastFrameLbl.Text = "Last Frame Timestamp";
            // 
            // firstFrameTimestampUpDown
            // 
            this.firstFrameTimestampUpDown.Enabled = false;
            this.firstFrameTimestampUpDown.Location = new System.Drawing.Point(224, 259);
            this.firstFrameTimestampUpDown.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.firstFrameTimestampUpDown.Name = "firstFrameTimestampUpDown";
            this.firstFrameTimestampUpDown.Size = new System.Drawing.Size(22, 22);
            this.firstFrameTimestampUpDown.TabIndex = 11;
            this.firstFrameTimestampUpDown.ValueChanged += new System.EventHandler(this.FirstFrameTimestampUpDown_ValueChanged);
            // 
            // firstFrameTimestamp
            // 
            this.firstFrameTimestamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstFrameTimestamp.Location = new System.Drawing.Point(94, 258);
            this.firstFrameTimestamp.Name = "firstFrameTimestamp";
            this.firstFrameTimestamp.ReadOnly = true;
            this.firstFrameTimestamp.Size = new System.Drawing.Size(129, 24);
            this.firstFrameTimestamp.TabIndex = 12;
            this.firstFrameTimestamp.Text = "00:00:00";
            // 
            // lastFrameTimestampUpDown
            // 
            this.lastFrameTimestampUpDown.Enabled = false;
            this.lastFrameTimestampUpDown.Location = new System.Drawing.Point(429, 259);
            this.lastFrameTimestampUpDown.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.lastFrameTimestampUpDown.Name = "lastFrameTimestampUpDown";
            this.lastFrameTimestampUpDown.Size = new System.Drawing.Size(22, 22);
            this.lastFrameTimestampUpDown.TabIndex = 11;
            this.lastFrameTimestampUpDown.ValueChanged += new System.EventHandler(this.LastFrameTimestampUpDown_ValueChanged);
            // 
            // lastFrameTimestamp
            // 
            this.lastFrameTimestamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastFrameTimestamp.Location = new System.Drawing.Point(299, 258);
            this.lastFrameTimestamp.Name = "lastFrameTimestamp";
            this.lastFrameTimestamp.ReadOnly = true;
            this.lastFrameTimestamp.Size = new System.Drawing.Size(129, 24);
            this.lastFrameTimestamp.TabIndex = 12;
            this.lastFrameTimestamp.Text = "00:00:00";
            // 
            // endVideoTimestampBtn
            // 
            this.endVideoTimestampBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endVideoTimestampBtn.Enabled = false;
            this.endVideoTimestampBtn.Image = ((System.Drawing.Image)(resources.GetObject("endVideoTimestampBtn.Image")));
            this.endVideoTimestampBtn.InitialImage = null;
            this.endVideoTimestampBtn.Location = new System.Drawing.Point(478, 253);
            this.endVideoTimestampBtn.Name = "endVideoTimestampBtn";
            this.endVideoTimestampBtn.Size = new System.Drawing.Size(37, 36);
            this.endVideoTimestampBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.endVideoTimestampBtn.TabIndex = 13;
            this.endVideoTimestampBtn.TabStop = false;
            this.endVideoTimestampBtn.Click += new System.EventHandler(this.EndVideoTimestampBtn_Click);
            // 
            // startVideoTimestampBtn
            // 
            this.startVideoTimestampBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startVideoTimestampBtn.Enabled = false;
            this.startVideoTimestampBtn.Image = ((System.Drawing.Image)(resources.GetObject("startVideoTimestampBtn.Image")));
            this.startVideoTimestampBtn.InitialImage = null;
            this.startVideoTimestampBtn.Location = new System.Drawing.Point(32, 253);
            this.startVideoTimestampBtn.Name = "startVideoTimestampBtn";
            this.startVideoTimestampBtn.Size = new System.Drawing.Size(37, 36);
            this.startVideoTimestampBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startVideoTimestampBtn.TabIndex = 13;
            this.startVideoTimestampBtn.TabStop = false;
            this.startVideoTimestampBtn.Click += new System.EventHandler(this.StartVideoTimestampBtn_Click);
            // 
            // formatPicker
            // 
            this.formatPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatPicker.Enabled = false;
            this.formatPicker.FormattingEnabled = true;
            this.formatPicker.Items.AddRange(new object[] {
            "jpg",
            "png",
            "bmp"});
            this.formatPicker.Location = new System.Drawing.Point(456, 186);
            this.formatPicker.Name = "formatPicker";
            this.formatPicker.Size = new System.Drawing.Size(59, 24);
            this.formatPicker.TabIndex = 14;
            this.formatPicker.SelectedIndexChanged += new System.EventHandler(this.formatPicker_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Output Format";
            // 
            // trackBar
            // 
            this.trackBar.Enabled = false;
            this.trackBar.LargeChange = 1;
            this.trackBar.Location = new System.Drawing.Point(32, 314);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(483, 56);
            this.trackBar.TabIndex = 16;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(94, 339);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(141, 21);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Control first frame";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(299, 339);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(140, 21);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.Text = "Control last frame";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2});
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Enabled = false;
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Made by Ognjen Marinkovic";
            // 
            // FrameEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 543);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formatPicker);
            this.Controls.Add(this.startVideoTimestampBtn);
            this.Controls.Add(this.endVideoTimestampBtn);
            this.Controls.Add(this.lastFrameTimestamp);
            this.Controls.Add(this.lastFrameTimestampUpDown);
            this.Controls.Add(this.firstFrameTimestamp);
            this.Controls.Add(this.firstFrameTimestampUpDown);
            this.Controls.Add(this.lastFrameLbl);
            this.Controls.Add(this.firstFramelbl);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.extractBtn);
            this.Controls.Add(this.outputFolderTxtbox);
            this.Controls.Add(this.selectVideoTxtbox);
            this.Controls.Add(this.outputFolderBtn);
            this.Controls.Add(this.outputFolderLbl);
            this.Controls.Add(this.selectVideoLbl);
            this.Controls.Add(this.selectVideoBtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(564, 590);
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(564, 590);
            this.Name = "FrameEx";
            this.Text = "FrameEx";
            ((System.ComponentModel.ISupportInitialize)(this.firstFrameTimestampUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastFrameTimestampUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endVideoTimestampBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startVideoTimestampBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectVideoBtn;
        private System.Windows.Forms.Label selectVideoLbl;
        private System.Windows.Forms.Label outputFolderLbl;
        private System.Windows.Forms.Button outputFolderBtn;
        private System.Windows.Forms.TextBox selectVideoTxtbox;
        private System.Windows.Forms.TextBox outputFolderTxtbox;
        private System.Windows.Forms.Button extractBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label firstFramelbl;
        private System.Windows.Forms.Label lastFrameLbl;
        private System.Windows.Forms.TextBox firstFrameTimestamp;
        private System.Windows.Forms.NumericUpDown firstFrameTimestampUpDown;
        private System.Windows.Forms.NumericUpDown lastFrameTimestampUpDown;
        private System.Windows.Forms.TextBox lastFrameTimestamp;
        private System.Windows.Forms.PictureBox endVideoTimestampBtn;
        private System.Windows.Forms.PictureBox startVideoTimestampBtn;
        private System.Windows.Forms.ComboBox formatPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
    }
}

