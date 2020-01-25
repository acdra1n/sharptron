using CefSharp;
using CefSharp.WinForms;
using Sharptron.Core;
using Sharptron.Core.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharptron
{
    static class SharptronApp
    {
        public static string AppDir { get; set; } = Application.StartupPath;
        public static string BinsDir { get; set; }
        public static string ResourcesDir { get; set; }

        /// <summary>
        /// The main entry point for Sharptron.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            CefSettings settings = new CefSettings();
            CefSharpSettings.WcfEnabled = true;
            Cef.EnableHighDPISupport();
            settings.CefCommandLineArgs.Add("enable-media-stream", "1");
            Cef.Initialize(settings);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Directory.Exists(BinsDir = Path.Combine(AppDir, "bins")))
                Directory.CreateDirectory(BinsDir);

            if (!Directory.Exists(ResourcesDir = Path.Combine(AppDir, "resources")))
                Directory.CreateDirectory(ResourcesDir);

            // Find main entry point in "bins" folder

            SharptronApplication app = null;
            // TODO add checking for exceptions, etc.
            // Also add a logger
            foreach(var bin in Directory.GetFiles(BinsDir, "*.sdll", SearchOption.AllDirectories))
            {
                foreach(var type in Assembly.LoadFile(bin).GetTypes())
                {
                    if ((!type.IsClass) || type.IsNotPublic)
                        continue;
                    if(typeof(SharptronApplication).IsAssignableFrom(type))
                    {
                        // Found app
                        app = Activator.CreateInstance(type) as SharptronApplication;
                    }
                }
            }

            // Run this when no valid binary has been found.
            // If the default resources do not exist, show an error stating no main binary could be found.
            // During the app process, show exception dialogs whenever they occur.
#if DEBUG
            if (app == null)
            {
                BrowserWindow window = new BrowserWindow(Path.Combine(ResourcesDir, "default\\index.html"));
                window.SyncTitle = false;
                window.SetTitle("Sharptron");
                Application.Run(window.BaseWindow);
            }
            else app.Main(args);
#endif

            //Application.Run(new BrowserWindowBase("http://ptb.discordapp.com/app"));
        }
    }
}
