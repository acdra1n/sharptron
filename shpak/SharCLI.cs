using Shar.CLI;
using Shar.CLI.Commands;
using Shar.Core;
using Shar.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shar
{
    class SharCLI
    {
        public static void Error(string msg, params object[] o)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg, o);
            Console.ResetColor();
        }

        static void RegisterStandardCommands()
        {
            CommandRegistry.RegisterCommand("info", new CommandInfo());
            CommandRegistry.CommandAliases["i"] = "info";
            CommandRegistry.RegisterCommand("add", new CommandAdd());
            CommandRegistry.CommandAliases["a"] = "add";
        }

        static int Main(string[] args)
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
                    Console.WriteLine("Sharptron Archiver (SHAR) v1.0");
                    return 0;
                }
                else if(proc.HasOption("help"))
                {
                    Console.WriteLine(Resources.CommandHelp);
                    return 0;
                }
                
                if(proc.UsefulArguments.Length < 1) // We do not have a command
                {
                    Console.WriteLine(Resources.CommandHelp);
                    return 0;
                }

                RegisterStandardCommands();

                if(!CommandRegistry.Exists(proc.UsefulArguments[0]))
                {
                    Error("error: command `{0}` is not valid.", proc.UsefulArguments[0]);
                    return 127;
                }

                return CommandRegistry.Execute(proc.UsefulArguments[0], proc.UsefulArguments);
            }
            catch (SharException ex)
            {
                Error("shpak error: " + ex.Message.ToLower());
                return 1;
            }
            catch (FileNotFoundException ex)
            {
                Error("error: " + ex.Message.ToLower());
                return 1;
            }
            catch (CliOptionNotFoundException ex)
            {
                Error("error: invalid option `{0}`", ex.optionName);
                return 1;
            }
            catch (CliException ex)
            {
                Error("error: {0}", ex.Message);
                return 1;
            }
            catch (Exception ex)
            {
                Error("An unidentifable error has occured. We urge you to contact a developer to resolve this issue as soon as possible.\n\nError Details:\n Message: {0}\n Stack Trace: {1}", ex.Message, ex.StackTrace);
                return 1;
            }
        }
    }
}
