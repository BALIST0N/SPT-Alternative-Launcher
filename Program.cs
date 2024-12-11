namespace SPT_Alt_Launcher
{
    //build this app in a single file with this command on terminal (vs2022 -> view -> terminal) :
    /*      dotnet publish -r win-x64 /p:PublishSingleFile=true /p:IncludeAllContentForSelfExtract=true --self-contained false  */

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
            Application.Run(new MainWindow());
        }
    }
}