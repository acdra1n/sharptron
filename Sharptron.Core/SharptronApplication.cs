using Sharptron.Core.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharptron.Core
{
    /// <summary>
    /// Represents a Sharptron application.
    /// </summary>
    public abstract class SharptronApplication
    {
        /// <summary>
        /// The entry point of the application.
        /// </summary>
        /// <param name="args">The arguments passed.</param>
        public abstract void Main(string[] args);

        /// <summary>
        /// Called when the application is about to be terminated.
        /// </summary>
        public abstract void OnTerminate();

        /// <summary>
        /// Starts a browser window as the main window.
        /// </summary>
        /// <param name="bw">The browser window to use.</param>
        public static void StartAsMainWindow(BrowserWindow bw)
        {
            bw.IsAppWindow = true;
            Application.Run(bw.BaseWindow);
        }
    }
}
