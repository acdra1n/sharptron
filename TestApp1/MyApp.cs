using Sharptron.Core;
using Sharptron.Core.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    public class MyApp : SharptronApplication
    {
        public override void Main(string[] args)
        {
            BrowserWindow bw = new BrowserWindow("http://discordapp.com/app");
            bw.IsAppWindow = true;
            bw.SyncTitle = false;
            bw.SetTitle("Discord");
            bw.SetIcon("app.ico");
            StartAsMainWindow(bw);
        }
    }
}
