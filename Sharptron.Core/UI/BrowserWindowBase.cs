using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;

namespace Sharptron.Core.UI
{
    public partial class BrowserWindowBase : Form
    {
        internal ChromiumWebBrowser browser;

        public static string InitialUrl { get; protected set; }
        public Queue<Action> QueuedTasks { get; private set; }

        public BrowserWindowBase()
        {
            InitializeComponent();
            InitialUrl = "about:blank"; //TODO set to Sharptron default page
        }

        public BrowserWindowBase(string url)
        {
            InitializeComponent();
            InitialUrl = url;
        }

        private void BrowserWindowBase_Load(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser(InitialUrl);
            browser.Dock = DockStyle.Fill;
            this.Controls.Add(browser);
        }
    }
}
