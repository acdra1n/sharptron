using shpakcore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shpak
{
    class ShpakCLI
    {
        static void Main(string[] args)
        {
            ShpakArchive sa = new ShpakArchive(args[0]);
        }
    }
}
