using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharptron.Core.UI
{
    /// <summary>
    /// Represents a window containing a Chromium browser view.
    /// </summary>
    public class BrowserWindow
    {
        public BrowserWindowBase BaseWindow { get; set; }

        /// <summary>
        /// Gets or sets whether the Chromium browser can change the window title.
        /// This property will have no effect once the browser window is shown.
        /// </summary>
        public bool SyncTitle
        {
            get
            {
                return BaseWindow.SyncTitle;
            }

            set
            {
                BaseWindow.SyncTitle = value;
            }
        }

        /// <summary>
        /// Creates a new browser window with size 640x480 and no URL target.
        /// </summary>
        public BrowserWindow()
        {
            BaseWindow = new BrowserWindowBase();
            BaseWindow.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Creates a new browser window size 640x480.
        /// </summary>
        /// <param name="url">The URL the browser view should display. Leave as null to create an empty window.</param>
        public BrowserWindow(string url)
        {
            if (url == null)
                url = "about:blank";

            BaseWindow = new BrowserWindowBase(url);
            BaseWindow.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Creates a new browser window.
        /// </summary>
        /// <param name="url">The URL the browser view should display. Leave as null to create an empty window.</param>
        /// <param name="size">The size to use when creating the window.</param>
        /// <param name="location">The initial location of the window.</param>
        public BrowserWindow(string url, Size size, Point location)
        {
            if (url == null)
                url = "about:blank";

            BaseWindow = new BrowserWindowBase(url);
            BaseWindow.StartPosition = FormStartPosition.Manual;
            BaseWindow.Size = new System.Drawing.Size(size.Width, size.Height);
            BaseWindow.Location = new System.Drawing.Point(location.X, location.Y);
        }

        /// <summary>
        /// Sets the title of this window.
        /// </summary>
        /// <param name="text">The new title to use.</param>
        public void SetTitle(string text)
        {
            BaseWindow.Text = text;
        }

        /// <summary>
        /// Sets the icon of this window.
        /// </summary>
        /// <param name="iconPath">The path of the icon to use.</param>
        public void SetIcon(string iconPath)
        {
            if (!File.Exists(iconPath))
                throw new FileNotFoundException("File does not exist", iconPath);
            BaseWindow.Icon = new System.Drawing.Icon(iconPath);
        }

        /// <summary>
        /// Shows the browser window.
        /// </summary>
        public void Show()
        {
            BaseWindow.Show();
        }
    }
}
