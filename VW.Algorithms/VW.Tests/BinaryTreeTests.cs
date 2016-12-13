using System;
using System.Collections;
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
        public BinaryTree<int> Tree { get; set; }

        [SetUp]
        public void Setup()
        {
            Tree = new BinaryTree<int>();
        }

        [TestCase(1)]
        [TestCase(100)]
        [TestCase(53)]
        public void Find_Root_By_Value(int arrangedValue)
        {
            //Arrange
            Tree.Root = new BinaryTreeNode<int>(arrangedValue);

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
            Tree.Root = new BinaryTreeNode<int>(1);

            //Act
            var result = Tree.Find(arrangedValue);

            //Assert
            result.Should().BeNull();
        }

        [TestCase(5)]
        [TestCase(88)]
        [TestCase(101)]
        public void Find_Returns_Right_Child_Node(int arrangedValue)
        {
            //Arrange
            Tree.Root = new BinaryTreeNode<int>(1);
            Tree.Root.RightNode = new BinaryTreeNode<int>(arrangedValue);

            //Act
            var result = Tree.Find(arrangedValue);

            //Assert
            result.Should().NotBeNull();
            result.Value.Should().Be(arrangedValue);
        }

        [TestCase(3)]
        [TestCase(33)]
        [TestCase(333)]
        public void Find_Returns_Left_Child_Node(int arrangedValue)
        {
            var hashTable = new Hashtable();

            //Arrange
            Tree.Root = new BinaryTreeNode<int>(1);
            Tree.Root.RightNode = new BinaryTreeNode<int>(arrangedValue);

            //Act
            var result = Tree.Find(arrangedValue);

            //Assert
            result.Should().NotBeNull();
            result.Value.Should().Be(arrangedValue);
        }

        /// <summary>
        /// Found Node Value must be inclusively contained in Range (0 to treeNodeCount)
        /// </summary>
        /// <param name="treeNodeCount"></param>
        /// <param name="foundNodeValue"></param>
        [TestCase(10, 2)]
        [TestCase(21, 21)]
        [TestCase(156, 24)]
        public void Find_Returns_Node_Contained_In_Dynamtically_Genrated_Tree(int treeNodeCount, int foundNodeValue)
        {
            //Arrange
            Tree.Root = new BinaryTreeNode<int>(0);
                        
            for (var i = 1; i < treeNodeCount; i++)
            {
                var currentNode = new BinaryTreeNode<int>(i);
                if (currentNode.LeftNode == null && i < treeNodeCount)
                {
                    currentNode.LeftNode = new BinaryTreeNode<int>(i++);
                }
                if (currentNode.RightNode == null && i < treeNodeCount)
                {
                    currentNode.RightNode = new BinaryTreeNode<int>(i++);
                }
            }
        }
    }
}
