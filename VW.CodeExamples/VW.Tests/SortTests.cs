using FluentAssertions;
using NUnit.Framework;
using VW.Algorithms;

namespace VW.Tests
{
    [TestFixture]
    public static class SortTests
    {
        public static int[] MyArray;

        [SetUp]
        public static void Setup()
        {
            MyArray = new[] { 4, 1, 9, 2093, 4850, 30, 17, 101, 58 };
        }

        [Test]
        public static void Validate_Quicksort()
        {
            //Act
            MyArray.QuickSort();

            //Assert
            MyArray.Should().BeInAscendingOrder();
        }

        [Test]
        public static void Validate_BubbleSort()
        {
            //Act
            MyArray.BubbleSort();

            //Assert
            MyArray.Should().BeInAscendingOrder();
        }

        [Test]
        public static void Validate_InsertionSort()
        {
            //Act
            MyArray.InsertionSort();

            //Assert
            MyArray.Should().BeInAscendingOrder();
        }

        [Test]
        public static void Get_Odd_Number_Occurrances()
        {
            //Act
            var result = new []{1,2,3,4,4,5,9,9,9,3}.FindOffNumberOfOccurances();

            //Assert
            result.Should().Equal(new[] {1, 2, 5, 9});
        }
    }
}
