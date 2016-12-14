using FluentAssertions;
using NUnit.Framework;
using VW.Algorithms;

//https://www.youtube.com/watch?v=1wMBw38rAlw
namespace VW.Tests
{
    [TestFixture]
    public static class SumPairTests
    {
        [SetUp]
        public static void Setup()
        {
        }

        [Test]
        public static void Test_SumPairExists()
        {
            var array = new int[] {2, 4, 5, 6, 9, 1};

            //
            var result = array.DoesSumPairExists(11);

            //Assert
            result.Should().BeTrue();
        }

        [Test]
        public static void Test_SumPairExists_NoMatchingPair()
        {
            var array = new int[] { 2, 4, 5, 1, 2, 8};

            //
            var result = array.DoesSumPairExists(11);

            //Assert
            result.Should().BeFalse();
        }
    }
}
