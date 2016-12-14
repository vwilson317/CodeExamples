using FluentAssertions;
using NUnit.Framework;
using VW.Algorithms;

//https://www.youtube.com/watch?v=1wMBw38rAlw
namespace VW.Tests
{
    [TestFixture]
    public static class LeastDisruptiveTests
    {
        [SetUp]
        public static void Setup()
        {
        }

        [Test]
        public static void Test_LeastDisruptiveReplacemntIndex()
        {
            var array = new[] {1,3,5,3,7,4,9,11,0};
            var replacementArray = new[] {6, 3};

            //Act
            array.ReplaceWithLeastDisruption(replacementArray);

            //Assert
            var expectedArray = new []{1,3,6,3,7,4,9,11,0};
            array.Should().Equal(expectedArray);
        }
    }
}
