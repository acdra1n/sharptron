using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharptron.Core
{
    /// <summary>
    /// Represents a Sharptron module.
    /// </summary>
    public abstract class SharptronModule
    {
        public abstract string Name { get; set; }
        public abstract string Version { get; set; }
        public abstract string Copyright { get; set; }
        public abstract string[] Authors { get; set; }
        public abstract string Description { get; set; }

        /// <summary>
        /// Called after the module is loaded.
        /// </summary>
        /// <param name="app">The current Sharptron application.</param>
        public abstract void OnEnable(SharptronApplication app);

        /// <summary>
        /// Called before the module is unloaded.
        /// </summary>
        public abstract void OnDisable();
    }
}
