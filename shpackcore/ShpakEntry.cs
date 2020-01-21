﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shpakcore
{
    public struct ShpakEntry
    {
        public string Path;
        public bool IsDirectory;
        public int BinLength;
        public byte[] BinData;
    }
}
