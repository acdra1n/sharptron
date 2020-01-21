using Shpak.CLI;
using Shpak.CLI.Commands;
using Shpak.Core;
using Shpak.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shpak
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
                
                if(proc.UsefulArguments.Length < 1) // We do not have a command
                {
                    Console.WriteLine(Resources.CommandHelp);
                    return;
                }

                if(!CommandRegistry.Exists(proc.UsefulArguments[0]))
                {
                    Error("error: command `{0}` is not valid.", proc.UsefulArguments[0]);
                    return;
                }

            }
            catch (ShpakException ex)
            {
                   
            }
            catch (CliOptionNotFoundException ex)
            {
                Error("error: invalid option `{0}`", ex.optionName);
            }
        }
    }
}
