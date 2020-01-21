using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shpakcore
{
    /// <summary>
    /// Represents a Shpak archive.
    /// </summary>
    public class ShpakArchive
    {
        /// <summary>
        /// Gets or sets the data storage method of this archive.
        /// </summary>
        public ShpakStorageMethod DataStorageMethod { get; set; } = ShpakStorageMethod.COMPRESS_DEFLATE;

        /// <summary>
        /// Returns the current latest archive version.
        /// </summary>
        public const float ARCHIVE_VERSION = 1.0f;

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

        public List<ShpakEntry> Entries { get; set; } = new List<ShpakEntry>();

        /// <summary>
        /// Removes all entries from the archive.
        /// </summary>
        public void ClearEntries()
        {
            Entries.Clear();
        }

        /// <summary>
        /// Saves the archive to disk.
        /// </summary>
        /// <param name="path">The path to save the archive.</param>
        public void Save(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                // Write magic and header

                bw.Write(0xEA00FC01);
                bw.Write(0xEA001000);
                bw.Write(ARCHIVE_VERSION);
                bw.Write((byte)DataStorageMethod);

                foreach(var e in Entries)
                {
                    bw.Write(e.Path);
                    bw.Write(e.IsDirectory);
                    
                    switch(DataStorageMethod)
                    {
                        case ShpakStorageMethod.COMPRESS_DEFLATE:
                            byte[] compressedBytes = Util.Compress(e.BinData);
                            bw.Write(compressedBytes.Length);
                            bw.Write(compressedBytes);
                            break;
                        case ShpakStorageMethod.STORE:
                            bw.Write(e.BinLength);
                            bw.Write(e.BinData);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Loads a Shpak archive from file.
        /// </summary>
        /// <param name="path">The path of the archive to load.</param>
        public void LoadFromFile(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                if (fs.Length < 16)
                    throw new ShpakException("Invalid archive - refusing to read.");

                if (br.ReadUInt32() != 0xEA00FC01)
                    throw new ShpakException("Invalid archive magic.");

                // Read archive header

                if (br.ReadUInt32() != 0xEA001000)
                    throw new ShpakException("Invalid header.");

                ShpakHeader hdr = new ShpakHeader()
                {
                    Version = br.ReadSingle(),
                    StorageMethod = (ShpakStorageMethod)br.ReadByte()
                };

                Console.WriteLine(hdr.StorageMethod);

                // Retrieve entries
                while(br.PeekChar() != -1)
                {
                    ShpakEntry entry = new ShpakEntry()
                    {
                        Path = br.ReadString(),
                        IsDirectory = br.ReadBoolean(),
                        BinLength = br.ReadInt32(),
                        BinData = new byte[] { }
                    };

                    switch(hdr.StorageMethod)
                    {
                        case ShpakStorageMethod.COMPRESS_DEFLATE:
                            entry.BinData = Util.Decompress(br.ReadBytes(entry.BinLength));
                            break;
                        case ShpakStorageMethod.STORE:
                            entry.BinData = br.ReadBytes(entry.BinLength);
                            break;
                    }

                    Entries.Add(entry);
                }
            }
        }
    }
}
