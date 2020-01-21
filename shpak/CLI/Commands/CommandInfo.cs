using Shpak.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shpak.CLI.Commands
{
    public class CommandInfo : ICLICommand
    {
        public int Execute(string[] args)
        {
            if (args.Length < 2)
                throw new CliException("no archive has been specified.");
            if (!File.Exists(args[1]))
                throw new FileNotFoundException("file `" + args[1] + "` does not exist.");

            ShpakArchive archive = new ShpakArchive(args[1]);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Archive Info for `{0}`\n", args[1]);
            Console.ResetColor();
            Console.WriteLine(" Compression method: {0}", archive.DataStorageMethod);
            Console.WriteLine(" No of entries: {0}", archive.Entries.Count);
            return 0;
        }
    }
}
