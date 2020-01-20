using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharptron.Core.Util
{
    public static class SyncExtensions
    {
        public static void InvokeIfRequired(this ISynchronizeInvoke ctrl, MethodInvoker method)
        {
            if (ctrl.InvokeRequired) ctrl.Invoke(method, null);
            else method();
        }
    }
}
