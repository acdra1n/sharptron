using Shar.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shar.CLI.Commands
{
    public class CommandAdd : ICLICommand
    {
        public int Execute(string[] args)
        {
            if (args.Length < 2)
                throw new CliException("no archive has been specified.");
            else if (args.Length < 3)
                throw new CliException("no file path was specified.");
            else if (args.Length < 4)
                throw new CliException("no archive path was specified.");

            if (!File.Exists(args[1]))
                throw new FileNotFoundException("file `" + args[2] + "` does not exist.");

            SharArchive archive;
            if(!File.Exists(args[1]))
            {
                Console.WriteLine("Creating archive at `{0}`...", args[1]);
                archive = new SharArchive();
            } else archive = new SharArchive(args[1]);

            Console.WriteLine("Adding file `{0}` at path `{1}`...", args[2], args[3]);
            archive.AddFile(args[3], File.ReadAllBytes(args[2]));
            Console.WriteLine("Saving archive...");
            archive.Save(args[1]);
            Console.WriteLine("Done.");
            return 0;
        }
    }
}
