using shpakcore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shpak
{
    class ShpakCLI
    {
        static void Main(string[] args)
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("test1.spk", FileMode.Create));
            bw.Write(0xEA00FC01);
            bw.Write(0xEA001000);
            bw.Write(1.0f);
            bw.Write((byte)ShpakStorageMethod.STORE);

            byte[] xyz = UTF8Encoding.UTF8.GetBytes("welcome to windows");

            bw.Write("/test.txt");
            bw.Write(false);
            bw.Write(xyz.Length);
            bw.Write(xyz);
           
            bw.Flush();
            bw.Close();
            ShpakArchive sa = new ShpakArchive(args[0]);
            
        }
    }
}
