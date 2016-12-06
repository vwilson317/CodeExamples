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

        [Test]        public static void Validate_BubbleSort()        {
            //Act
            MyArray.BubbleSort();

            //Assert
            MyArray.Should().BeInAscendingOrder();        }

        [Test]        public static void Validate_InsertionSort()        {
            //Act
            MyArray.InsertionSort();

            //Assert
            MyArray.Should().BeInAscendingOrder();        }
    }
}
