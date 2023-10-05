# FrameEx
- Extract frames from a video or only a part of it
- Supports mp4, m4v, mov, avi, mkv, wmv videos
- Release contains FFMPEG that is needed for app to work

![gui pic](gui.JPG)

## Steps:
1) Select the video you want to extract frames from
2) Select the output folder for the frames
3) Select the output format for frames (Optional)
4) Select timestamps of the first and the last frame of a sequence you want the frames extracted for (Optional)
5) EXTRACT
##


# For developers:
- The app is essentially a wrapper for calling frame extraction with FFmpeg.exe. Therefore you need the FFmpeg.exe in the same folder with FrameEx.exe.
- Don't forget to add FFmpeg inside debug folder for testing. If you build your own app, you can change variable 'ffmpegPath' in code as it suits you.
- Restore NuGet packages
- App target framework .NET Framework 4.5.2
- GUI created using WinForms
- Code is not clean and can be optimised a bit but it works fine and the app is fast.
