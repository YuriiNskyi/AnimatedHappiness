using BenchmarkDotNet.Running;

namespace AnimatedHappiness.Benchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<AnimatedHappinessCalculatorBenchmarks>();
        }
    }
}
