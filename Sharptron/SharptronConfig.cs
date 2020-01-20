using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharptron
{
    /// <summary>
    /// Represents the current Sharptron configuration.
    /// </summary>
    public class SharptronConfig
    {
        public bool WebRTCEnabled { get; set; } = true;
        public bool WebGLEnabled { get; set; } = true;
    }
}
