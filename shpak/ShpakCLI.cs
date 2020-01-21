using shpak.CLI;
using shpak.Properties;
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
        static void Error(string msg, params object[] o)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg, o);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            /*
             * SHPAK syntax
            ShpakArchive sa = new ShpakArchive(args[0]);
            sa.ClearEntries();
            sa.DataStorageMethod = ShpakStorageMethod.COMPRESS_DEFLATE;
            sa.AddTextFile("/README.TXT", "How are you doing today sir?");
            sa.Save("Hello.spk");
            */
            
            CliArgumentProcessor proc = new CliArgumentProcessor(args, new CliOption("version", CliOptionValueType.None, "V"), new CliOption("help", CliOptionValueType.None, "h"));
            try
            {
                proc.Process();
                if(proc.HasOption("version"))
                {
                    Console.WriteLine("Shpak v1.0");
                    return;
                }
                else if(proc.HasOption("help"))
                {
                    Console.WriteLine(Resources.CommandHelp);
                    return;
                }
            }
            catch (CliOptionNotFoundException ex)
            {
                Error("error: invalid option `{0}`", ex.optionName);
            }
        }
    }
}
