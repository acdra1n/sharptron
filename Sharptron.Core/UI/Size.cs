using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharptron.Core.UI
{
    /// <summary>
    /// Represents a size in terms of its height and width.
    /// </summary>
    public struct Size
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Size(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
