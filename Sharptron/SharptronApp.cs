using CefSharp;
using CefSharp.WinForms;
using Sharptron.Core.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharptron
{
    static class SharptronApp
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CefSettings settings = new CefSettings();
            settings.CefCommandLineArgs.Add("enable-media-stream", "1");
            Cef.Initialize(settings);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new BrowserWindowBase("http://ptb.discordapp.com/app"));
        }
    }
}
