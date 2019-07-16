using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace VW.Tests
{
    [TestFixture]
    public class FibTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(6, 5)]
        [TestCase(9, 21)]
        public void Verify(int index, int expectedVal)
        {
            //act
            var fibAtIndex = FibRecursive(index);
            var fibSeq = FibLinear(index);

            fibAtIndex.Should().Be(expectedVal);
            fibSeq.Count.Should().Be(index + 1);
            fibSeq[index].Should().Be(expectedVal);
        }

        public static int FibRecursive(int currentIndex)
        {
            if (currentIndex <= 3)
            {
                if (currentIndex == 0)
                    return 0;

                return 1;
            }

            return FibRecursive(currentIndex - 1) + FibRecursive(currentIndex - 2);
        }

        private static List<int> FibLinear(int index)
        {
            var fibSeq = new List<int>();

            for (int i = 0; i <= index; i++)
            {
                FibLinear(i, fibSeq);
            }

            return fibSeq;
        }

        public static List<int> FibLinear(int index, List<int> fibNumbers)
        {
            if (index <= 3)
            {
                fibNumbers.Add(index == 0 ? 0 : 1);
            }
            else
                fibNumbers.Add(fibNumbers[index - 1] + fibNumbers[index -2]);

            return fibNumbers;
        }
    }
}