using AnimatedHappiness.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimatedHappiness.Tests
{
    [TestClass]
    public class AnimatedHappinessCalculatorTests
    {
        private readonly int[] _firstArray = { 0, 1, 2, 2, 2, 2, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 10, 10, 10 };
        private readonly int[] _secondArray = { 5, 5, 5, 6, 6, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        [TestMethod]
        public void CalculateUniqueNumbers_ValidArguments_ValidResult()
        {
            int[] uniqueNumbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            CollectionAssert.AreEqual(uniqueNumbers, 
                AnimatedHappinessCalculator.CalculateUniqueNumbers(_firstArray, _secondArray),
                "Numbers aren't unique after CalculateUniqueNumbers method.");
        }

        [TestMethod]
        public void CalculateUniqueOddNumbers_ValidArguments_ValidResult()
        {
            Dictionary<int, int> uniqueOddNumbers = new Dictionary<int, int>
            {
                [1] = 0,
                [3] = 0,
                [5] = 3,
                [7] = 1,
                [9] = 1
            };

            CollectionAssert.AreEqual(uniqueOddNumbers, 
                AnimatedHappinessCalculator.CalculateUniqueOddNumbers(_firstArray, _secondArray),
                "Numbers aren't unique after CalculateUniqueOddNumbers method.");
        }

        [TestMethod]
        public void CalculateEvenNumbersSum_ValidArguments_ValidResult()
        {
            var sum = 14;

            Assert.AreEqual(sum,
                AnimatedHappinessCalculator.CalculateEvenNumbersSum(_firstArray, _secondArray),
                "Numbers aren't unique after CalculateEvenNumbersSum method.");
        }

        [TestMethod]
        public void CalculateUniqueNumbers_EmptyArguments_ValidResult()
        {
            CollectionAssert.AreEqual(_firstArray.Distinct().ToArray(), AnimatedHappinessCalculator.CalculateUniqueNumbers(_firstArray, Enumerable.Empty<int>()),
                "Incorrect result when second array is empty.");

            CollectionAssert.AreEqual(_secondArray.Distinct().ToArray(), AnimatedHappinessCalculator.CalculateUniqueNumbers(Enumerable.Empty<int>(), _secondArray),
                "Incorrect result when first array is empty.");

            CollectionAssert.AreEqual(Array.Empty<int>(), AnimatedHappinessCalculator.CalculateUniqueNumbers(Enumerable.Empty<int>(), Enumerable.Empty<int>()),
                "Incorrect result when both arrays are empty.");
        }

        [TestMethod]
        public void CalculateUniqueOddNumbers_EmptyArguments_ValidResult()
        {
            var firstResult = new Dictionary<int, int>
            {
                [1] = 0,
                [3] = 0,
                [5] = 0,
                [7] = 0,
                [9] = 0
            };
            CollectionAssert.AreEqual(firstResult, AnimatedHappinessCalculator.CalculateUniqueOddNumbers(_firstArray, Enumerable.Empty<int>()),
                "Incorrect result when second array is empty.");

            var secondResult = new Dictionary<int, int>();       
            CollectionAssert.AreEqual(secondResult, AnimatedHappinessCalculator.CalculateUniqueOddNumbers(Enumerable.Empty<int>(), _secondArray),
                "Incorrect result when first array is empty.");

            var emptyResult = new Dictionary<int, int>();
            CollectionAssert.AreEqual(emptyResult, AnimatedHappinessCalculator.CalculateUniqueOddNumbers(Enumerable.Empty<int>(), Enumerable.Empty<int>()),
                "Incorrect result when both arrays are empty.");
        }

        [TestMethod]
        public void CalculateEvenNumbersSum_EmptyArguments_ValidResult()
        {
            Assert.AreEqual(58, AnimatedHappinessCalculator.CalculateEvenNumbersSum(_firstArray, Enumerable.Empty<int>()),
                "Incorrect result when second array is empty.");

            Assert.AreEqual(0, AnimatedHappinessCalculator.CalculateEvenNumbersSum(Enumerable.Empty<int>(), _secondArray),
                "Incorrect result when first array is empty.");

            Assert.AreEqual(0, AnimatedHappinessCalculator.CalculateEvenNumbersSum(Enumerable.Empty<int>(), Enumerable.Empty<int>()),
                "Incorrect result when both arrays are empty.");
        }

        [TestMethod]
        public void CalculateUniqueNumbers_NullArguments_ThrowsException()
        {
            Assert.ThrowsException<ArgumentNullException>(()
                => AnimatedHappinessCalculator.CalculateUniqueNumbers(_firstArray, null));

            Assert.ThrowsException<ArgumentNullException>(()
                => AnimatedHappinessCalculator.CalculateUniqueNumbers(null, _secondArray));

            Assert.ThrowsException<ArgumentNullException>(()
                => AnimatedHappinessCalculator.CalculateUniqueNumbers(null, null));
        }

        [TestMethod]
        public void CalculateUniqueOddNumbers_NullArguments_ThrowsException()
        {
            Assert.ThrowsException<ArgumentNullException>(()
                => AnimatedHappinessCalculator.CalculateUniqueOddNumbers(_firstArray, null));

            Assert.ThrowsException<ArgumentNullException>(()
                => AnimatedHappinessCalculator.CalculateUniqueOddNumbers(null, _secondArray));

            Assert.ThrowsException<ArgumentNullException>(()
                => AnimatedHappinessCalculator.CalculateUniqueOddNumbers(null, null));
        }

        // Long lambda syntax here to avoid Box allocation,
        // to user constructor with Action, instead of Func<object>
        [TestMethod]
        public void CalculateEvenNumbersSum_NullArguments_ThrowsException()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                AnimatedHappinessCalculator.CalculateEvenNumbersSum(_firstArray, null);
            });

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                AnimatedHappinessCalculator.CalculateEvenNumbersSum(null, _secondArray);
            });

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                AnimatedHappinessCalculator.CalculateEvenNumbersSum(null, null);
            });
        }
    }
}
