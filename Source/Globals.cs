namespace SPT_Alt_Launcher
{
    public class Globals
	{
		public static string gameFolder;
		public static string serverFolder;
		public static string profilesFolder;
		public static string backendUrl;
		
		static Globals()
		{
			#if DEBUG
				serverFolder = "D:/TARKOV/SPT";
			#else
				serverFolder = Environment.CurrentDirectory;
			#endif

            profilesFolder = serverFolder + "/user/profiles";

			gameFolder = Properties.Settings.Default.gameFolder;
			backendUrl = Properties.Settings.Default.backendURL;

            /** 
             * 
			 * resources for game patcher :
			 * .bpf /SPT_Data/Launcher/Patches/SPT-core/EscapeFromTarkov_Data/Managed/Assembly-CSharp.dll.bpf
			 * .dll /EscapeFromTarkov_Data/Managed/Assembly-CSharp.dll
			 * 
			**/
        }
    }
}