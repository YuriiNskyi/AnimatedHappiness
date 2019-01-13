using CommandLine;

namespace AnimatedHappiness
{
    public class CommandLineOptions
    {
        [Option('p', "path", Required = true, HelpText = "Path to the specified .json file.")]
        public string Path { get; set; }
    }
}
