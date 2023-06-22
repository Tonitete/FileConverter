using FileConverter.Main.Views;
using Xabe.FFmpeg;
using Xabe.FFmpeg.Downloader;

namespace FileConverter.Main
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Get latest version of FFmpeg. It's great idea if you don't know if you had installed FFmpeg.
            FFmpegDownloader.GetLatestVersion(FFmpegVersion.Official);
            Application.Run(new MainMenu());
        }
    }
}