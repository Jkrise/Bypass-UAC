using System.ServiceProcess;

namespace Toolkit
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new LoaderService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
