using AnimatedHappiness.Core;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimatedHappiness.Benchmarks
{
    public class AnimatedHappinessCalculatorBenchmarks
    {
        private readonly Random _random = new Random();

        private readonly Consumer _consumer = new Consumer();

        [Params(0, 1, 5, 10, 25, 50, 100, 250, 500, 1000)]
        public int Length { get; set; }

        public IEnumerable<int> First => Enumerable.Repeat(0, Length).Select(x => _random.Next());
        public IEnumerable<int> Second => Enumerable.Repeat(0, Length).Select(x => _random.Next());

        [Benchmark]
        public void CalculateUniqueNumbers() 
            => AnimatedHappinessCalculator.CalculateUniqueNumbers(First, Second).Consume(_consumer);

        [Benchmark]
        public IDictionary<int, int> CalculateUniqueOddNumbers()
            => AnimatedHappinessCalculator.CalculateUniqueOddNumbers(First, Second);

        [Benchmark]
        public int CalculateEvenNumbersSum()
            => AnimatedHappinessCalculator.CalculateEvenNumbersSum(First, Second);
    }
}
