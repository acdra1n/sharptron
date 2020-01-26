using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shar.Core
{
    public struct SharEntry
    {
        public string Path;
        public bool IsDirectory;
        public int BinLength;
        public byte[] BinData;
    }
}
