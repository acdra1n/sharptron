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
using Sharptron.Core.Util;

namespace Sharptron.Core.UI
{
    /// <summary>
    /// The inner window used to display a browser window.
    /// </summary>
    public partial class BrowserWindowBase : Form
    {
        internal ChromiumWebBrowser browser;

        public static string InitialUrl { get; protected set; }
        public Queue<Action> QueuedTasks { get; private set; }
        public bool SyncTitle { get; internal set; } = true;
        public bool OnlyDisplayWhenFinished { get; internal set; }

        private bool initialFrameLoadingFinished = false;

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
            browser.IsBrowserInitializedChanged += Browser_IsBrowserInitializedChanged;
            browser.FrameLoadStart += Browser_FrameLoadStart;
            browser.FrameLoadEnd += Browser_FrameLoadEnd;
            browser.TitleChanged += Browser_TitleChanged;
            browser.JavascriptObjectRepository.ResolveObject += JavascriptObjectRepository_ResolveObject;
            browser.Dock = DockStyle.Fill;
            this.Controls.Add(browser);
        }

        private void JavascriptObjectRepository_ResolveObject(object sender, CefSharp.Event.JavascriptBindingEventArgs e)
        {
            var repo = e.ObjectRepository;
            if(e.ObjectName == "sharptron")
            {
                repo.Register("sharptron", new JSBindings.SharptronJSObject(), isAsync: true);
            }
        }

        private void Browser_FrameLoadStart(object sender, FrameLoadStartEventArgs e)
        {
            // TODO to remove CefSharp exposure ==> 
            e.Frame.ExecuteJavaScriptAsync(@"CefSharp.BindObjectAsync('sharptron');delete CefSharp; delete cefSharp; var XYZ = 3;");
        }

        private void Browser_IsBrowserInitializedChanged(object sender, EventArgs e)
        {
            // TODO do window show hide
            // browser.ShowDevTools();
        }

        private void Browser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            if(SyncTitle)
            {
                this.InvokeIfRequired(() =>
                {
                    Text = e.Title;
                });
            }
        }

        private void Browser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            
        }
    }
}
