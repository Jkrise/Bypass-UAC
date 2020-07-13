using System;
using System.ServiceProcess;

namespace Toolkit
{
    public partial class LoaderService : ServiceBase
    {
        public LoaderService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // the name of the application to launch;
            // to launch an application using the full command path simply escape
            // the path with quotes, for example to launch firefox.exe:
            // String applicationName = "\"C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe\"";
            //string applicationName = "cmd.exe";

            // launch the application
            //ApplicationLoader.PROCESS_INFORMATION procInfo;
            //ApplicationLoader.StartProcessAndBypassUAC(applicationName, out procInfo, isHidden);
        }

        protected override void OnCustomCommand(int command)
        {
            bool isHidden = false;
            string applicationName = null;
            ApplicationLoader.PROCESS_INFORMATION procInfo;
            if (command == 222)
            {
                applicationName = "cmd.exe /T:0A /k title ALM Launcher Beta";
            }
            else if (command == 223)
            {
                applicationName = "Notepad.exe";
            }
            else if (command == 224)
            {
                applicationName = "taskmgr.exe";
            }
            else if (command == 225)
            {
                applicationName = Environment.GetEnvironmentVariable("WT6") + "WinTOTAL.exe";
            }
            else if (command == 226)
            {
                applicationName = Environment.GetEnvironmentVariable("TSA6");
            }
            else if (command == 227)
            {
                applicationName = Environment.GetEnvironmentVariable("TM3") + "\\Menu4.exe";
            }
            else if (command == 255)
            {
                applicationName = Environment.GetEnvironmentVariable("TM3") + "\\Menu.exe C:\\Users\\jkrise\\Desktop\\AHK\\Menu3\\Menu3.ahk";
            }
            else if (command == 210)
            {
                applicationName = Environment.GetEnvironmentVariable("Windir") + "\\Syswow64\\rundll32.exe shell32.dll,#61 10";
                isHidden = true;
            }
            else
            {
                return;
            }

            if (applicationName != null)
            {
                // launch the application
                ApplicationLoader.StartProcessAndBypassUAC(applicationName, out procInfo, isHidden);
            }
        }

        protected override void OnStop()
        {
        }

    }
}
