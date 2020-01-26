using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shar.CLI.Commands
{
    public static class CommandRegistry
    {
        public static Dictionary<string, string> CommandAliases { get; set; } = new Dictionary<string, string>();
        public static Dictionary<string, ICLICommand> RegisteredCommands { get; set; } = new Dictionary<string, ICLICommand>();

        /// <summary>
        /// Checks if the specified command exists.
        /// </summary>
        /// <param name="name">The name of the command to check for.</param>
        /// <returns></returns>
        public static bool Exists(string name)
        {
            if (CommandAliases.ContainsKey(name))
                name = CommandAliases[name];
            return RegisteredCommands.ContainsKey(name);
        }

        /// <summary>
        /// Defines an alias for a command.
        /// </summary>
        /// <param name="aliasName">The name of the alias.</param>
        /// <param name="commandName">The command to execute.</param>
        public static void DefineAlias(string aliasName, string commandName)
        {
            CommandAliases[aliasName] = commandName;
        }

        /// <summary>
        /// Registers a command.
        /// </summary>
        /// <param name="name">The name of the command to register.</param>
        /// <param name="cmd">The command instance to register.</param>
        public static void RegisterCommand(string name, ICLICommand cmd)
        {
            if (RegisteredCommands.ContainsKey(name))
                throw new CliException("Command already exists in registry!");
            RegisteredCommands[name] = cmd;
        }

        /// <summary>
        /// Executes the specified command.
        /// </summary>
        /// <param name="name">The name of the command to execute.</param>
        /// <param name="args">The arguments to pass to the command.</param>
        /// <returns></returns>
        public static int Execute(string name, string[] args)
        {
            // Check if this is an alias
            string cmdName = name;
            if (CommandAliases.ContainsKey(cmdName))
                cmdName = CommandAliases[cmdName];
            if (!RegisteredCommands.ContainsKey(cmdName))
                throw new CliException("Command does not exist.");
            return RegisteredCommands[cmdName].Execute(args);
        }
    }
}
