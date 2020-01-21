using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharptron.Core.JSBindings
{
    /// <summary>
    /// A class which defines the `Sharptron` JS object.
    /// </summary>
    public class SharptronJSObject
    {
        public int MBICON_ERROR = 0;
        public int MBICON_WARN = 1;
        public int MBICON_INFO = 2;

        public void QuitApplication(int code = 0)
        {
            Environment.Exit(code);
        }

        public void AlertBox(string caption, int iconId, string message)
        {
            MessageBoxIcon icon = MessageBoxIcon.None;

            switch(iconId)
            {
                default:
                    icon = MessageBoxIcon.None;
                    break;
                case 0:
                    icon = MessageBoxIcon.Error;
                    break;
                case 1:
                    icon = MessageBoxIcon.Warning;
                    break;
                case 2:
                    icon = MessageBoxIcon.Information;
                    break;
            }

            MessageBox.Show(message, caption, MessageBoxButtons.OK, icon);
        }

        public SharptronVersionInfo VersionInfo()
        {
            return new SharptronVersionInfo
            {
                SharptronVersion = 1.0f,
                ChromiumVer = Cef.ChromiumVersion,
                CefGitHash = Cef.CefCommitHash,
                CefVer = Cef.CefVersion
            };
        }
    }
}
