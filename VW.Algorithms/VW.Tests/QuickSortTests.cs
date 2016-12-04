using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using VW.Algorithms;
using VW.DataStructures;
using static VW.Algorithms.ArrayExtensionMethods;

namespace VW.Tests
{
    [TestFixture]
    public static class QuickSortTests
    {
        public static int[] myArray;

        [SetUp]
        public static void Setup()
        {
            myArray = new[] { 4, 1, 9, 2093, 4850, 30, 17, 101, 58 };
        }

        [Test]
        public static void Validate_Quicksort()
        {
            //Act
            myArray.QuickSort();

            //Assert
            myArray.Should().BeInAscendingOrder();
        }

        [Test]        public static void Validate_BubbleSort()        {
            //Act
            myArray.BubbleSort();

            //Assert
            myArray.Should().BeInAscendingOrder();        }
    }
}
