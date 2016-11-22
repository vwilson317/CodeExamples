using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using VW.DataStructures;

namespace VW.Tests
{
    [TestFixture]
    public class BinaryTreeTests
    {
        public BinaryTree Tree { get; set; }

        [SetUp]
        public void Setup()
        {
            Tree = new BinaryTree();
        }

        [TestCase(1)]
        [TestCase(100)]
        [TestCase(53)]
        public void Find_Root_By_Value(int arrangedValue)
        {
            //Arrange
            Tree.Root = new Node
            {
                Value = arrangedValue
            };

            //Act
            var result = Tree.Find(arrangedValue);

            //Assert
            result.Should().NotBeNull();
            result.Value.Should().Be(arrangedValue);
        }

        public void Find_Returns_Null_When_No_Root_Node()
        {
            var result = Tree.Find(new Random().Next());

            //Assert
            result.Should().BeNull();
        }

        [TestCase(0)]
        [TestCase(23)]
        [TestCase(19632)]
        public void Find_Returns_Null_When_Value_Not_Contained_In_Tree(int arrangedValue)
        {
            //Arrange
            Tree.Root = new Node
            {
                Value = 1
            };

            //Act
            var result = Tree.Find(arrangedValue);

            //Assert
            result.Should().BeNull();
        }
    }
}
