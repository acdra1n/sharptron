using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharptron.Core
{
    /// <summary>
    /// Represents a Sharptron application.
    /// </summary>
    public abstract class SharptronApplication
    {
        public abstract void Main(string[] args);
    }
}
