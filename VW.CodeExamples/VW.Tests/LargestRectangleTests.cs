using System.Collections.Generic;
using System.Collections.Specialized;
using System.Numerics;
using FluentAssertions;
using NUnit.Framework;
using VW.Algorithms;
using System.Windows;

//https://www.youtube.com/watch?v=VNbkzsnllsU
namespace VW.Tests
{
    [TestFixture]
    public static class LargestRectangleTests
    {
        [SetUp]
        public static void Setup()
        {

        }

        [Test]
        public static void FindMaxRectang()
        {
            var histogram = new LinkedList<int>();
            histogram.AddLast(1);
            histogram.AddLast(3);
            histogram.AddLast(2);
            histogram.AddLast(1);
            histogram.AddLast(2);
            //Break in the histogram
            histogram.AddLast(0);
            histogram.AddLast(1);
            histogram.AddLast(1);
            histogram.AddLast(1);

            //Act
            var largestRec = FindLargestRectangle(histogram);

            //Assert
            largestRec.Should().Be(5);
        }

        private static int FindLargestRectangle(LinkedList<int> graph)
        {
            var positionStack = new Stack<int>();
            var heightStack = new Stack<int>();
            var currentLargest = 0;
            var currentIndex = 0;

            var enumerator = graph.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var currentValue = enumerator.Current;

                if (heightStack.Count == 0 || heightStack.Peek() < currentValue)
                {
                    if (currentValue > currentLargest)
                    {
                        currentLargest = currentValue;
                    }
                    positionStack.Push(currentIndex);
                    heightStack.Push(currentValue);
                }
                else
                {
                    var size = heightStack.Pop() * (currentIndex - positionStack.Pop());
                    heightStack.Push(currentValue);

                    if (size > currentLargest)
                    {
                        currentLargest = size;
                    }
                }

                currentIndex++;
            }

            return currentLargest;
        }
    }
}
