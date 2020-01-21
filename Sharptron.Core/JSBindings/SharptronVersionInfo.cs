using CefSharp.WinForms;
using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharptron.Core.JSBindings
{
    public struct SharptronVersionInfo
    {
        public float SharptronVersion { get; set; }
        public string ChromiumVer { get; set; }
        public string CefVer { get; set; }
        public string CefGitHash { get; set; }
    }
}
