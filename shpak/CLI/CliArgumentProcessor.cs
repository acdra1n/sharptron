using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shar.CLI
{
    /// <summary>
    /// A class assisting with processing of CLI arguments.
    /// </summary>
    public class CliArgumentProcessor
    {
        private string[] args;
        private List<CliOption> registeredCliOptions;
        private Dictionary<string, object> optionsKvp = new Dictionary<string, object>();

        /// <summary>
        /// An array containing the useful arguments retained by this CLI processor (remainders).
        /// </summary>
        public string[] UsefulArguments { get; set; } = { };

        /// <summary>
        /// Creates a new CLI arguments processor with the specified parameters.
        /// </summary>
        /// <param name="args">The arguments to process.</param>
        public CliArgumentProcessor(string[] args, params CliOption[] definedOptions)
        {
            this.args = args;
            this.registeredCliOptions = definedOptions.ToList();
        }

        private CliOption GetOptionObject(string name)
        {
            return registeredCliOptions.Find(o => (o.Name == name) || o.Aliases.Contains(name));
        }

        /// <summary>
        /// Checks whether an option has been specified.
        /// </summary>
        /// <param name="name">The name of the option to check for.</param>
        /// <returns></returns>
        public bool HasOption(string name)
        {
            return optionsKvp.ContainsKey(name);
        }

        /// <summary>
        /// Begins the parsing of arguments.
        /// </summary>
        public void Process()
        {
            if (args.Length < 1) return;
            List<string> usefulArguments = new List<string>();

            for(var i = 0; i < args.Length; i++)
            {
                if (i >= args.Length) break;
                if (args[i].StartsWith("-")) //Check if argument is an option
                {
                    string optionName = args[i].StartsWith("--") ? args[i].Substring(2) : args[i].Substring(1);
                    CliOption specObject = GetOptionObject(optionName);
                    if (specObject == null)
                        throw new CliOptionNotFoundException("Invalid cli option.", optionName);
                    else
                    {
                        if (optionName != specObject.Name)
                            optionName = specObject.Name; // Remove alias
                        switch (specObject.ExpectedValue)
                        {
                            case CliOptionValueType.None:
                                optionsKvp[optionName] = new CliOptionNullValue();
                                continue; //only skip by one
                            case CliOptionValueType.String:
                                optionsKvp[optionName] = args[i + 1];
                                break;
                            case CliOptionValueType.Integer:
                                int v = 0;
                                if (!int.TryParse(args[i + 1].Trim(), out v))
                                    throw new CliOptionValueMismatchException(optionName, CliOptionValueType.Integer);
                                optionsKvp[optionName] = v;
                                break;
                        }
                        i += 2;
                        continue;
                    }
                }
                else usefulArguments.Add(args[i]);
            }

            UsefulArguments = usefulArguments.ToArray();
        }
    }
}
