using AnimatedHappiness.Core;
using CommandLine;
using Newtonsoft.Json;
using System;
using System.IO;

namespace AnimatedHappiness
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Parser.Default.ParseArguments<CommandLineOptions>(args)
                .WithParsed(option =>
                {
                    try
                    {
                        var json = File.ReadAllText(option.Path);

                        var parsed = JsonConvert.DeserializeObject<ParsedJson>(json);

                        var uniqueNumbers =
                            AnimatedHappinessCalculator.CalculateUniqueNumbers(parsed.First, parsed.Second);
                        Console.WriteLine($"Unique numbers in both arrays: {string.Join(",", uniqueNumbers)}");

                        Console.WriteLine();

                        var uniqueOddNumbers =
                            AnimatedHappinessCalculator.CalculateUniqueOddNumbers(parsed.First, parsed.Second);
                        Console.WriteLine("Unique odd numbers in first array and their quantity in second array:");
                        foreach (var number in uniqueOddNumbers)
                        {
                            Console.WriteLine($"{number.Key}: {number.Value}");
                        }

                        Console.WriteLine();

                        var sum = AnimatedHappinessCalculator.CalculateEvenNumbersSum(parsed.First, parsed.Second);
                        Console.WriteLine($"Sum of unique even numbers in first array, which not present in second array: {sum}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                });
        }
    }
}