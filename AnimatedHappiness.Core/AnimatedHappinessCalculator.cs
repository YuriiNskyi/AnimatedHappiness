using System.Collections.Generic;
using System.Linq;

namespace AnimatedHappiness.Core
{
    public static class AnimatedHappinessCalculator
    {
        // Should be close to O(n).
        public static int[] CalculateUniqueNumbers(IEnumerable<int> first, IEnumerable<int> second)
            => first.Union(second).ToArray();

        // Should be close to O(n).
        public static Dictionary<int, int> CalculateUniqueOddNumbers(IEnumerable<int> first, IEnumerable<int> second)
            => first.Where(x => x % 2 == 1).Distinct()
                .ToDictionary(k => k, e => second.Count(x => x == e));

        // Why do we use HashSet here? Due to its O(1) Contains operation, instead of O(n) Linq's Contains.
        // So, complexity must be O(n) in this case, instead of O(n^2).
        public static int CalculateEvenNumbersSum(IEnumerable<int> first, IEnumerable<int> second)
        {
            var secondUnique = new HashSet<int>(second);

            return first.Where(x => x % 2 == 0).Where(x => !secondUnique.Contains(x)).Sum();
        }
    }
}
