namespace Shpak.CLI
{
    public class CliOption
    {
        public CliOption()
        {
            Name = "unknown";
            Aliases = new string[] { };
            ExpectedValue = CliOptionValueType.None;
        }

        public CliOption(string name, CliOptionValueType expectedValue, params string[] aliases)
        {
            Name = name;
            Aliases = aliases;
            ExpectedValue = expectedValue;
        }

        public string Name { get; set; }
        public string[] Aliases { get; set; }
        public CliOptionValueType ExpectedValue { get; set; }
    }
}