using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shpakcore
{
    public class ShpakArchive
    {
        /// <summary>
        /// Creates a new Shpak archive.
        /// </summary>
        public ShpakArchive()
        {

        }

        /// <summary>
        /// Creates a new archive and loads a Shpak archive from file.
        /// </summary>
        /// <param name="path">The path of the archive to load.</param>
        public ShpakArchive(string path)
        {
            LoadFromFile(path);
        }
        
        /// <summary>
        /// Loads a Shpak archive from file.
        /// </summary>
        /// <param name="path">The path of the archive to load.</param>
        public void LoadFromFile(string path)
        {
            using (BinaryReader br = new BinaryReader(new FileStream(path, FileMode.Open)))
            {
                if(br.ReadUInt32() != 0xEA00FC01)
                    throw new ShpakException("Invalid archive magic.");
                
            }
        }
    }
}
