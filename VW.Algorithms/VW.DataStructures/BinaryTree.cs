using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW.DataStructures
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }

        public BinaryTreeNode<T> Find(int value)
        {
            var matchingNode = CheckNode(Root, value);
            return matchingNode;
        }

        private BinaryTreeNode<T> CheckNode(BinaryTreeNode<T> node, int value)
        {
            var returnNode = NodeValueEquals(node, value);
            if (returnNode != null)
            {
                return returnNode;
            }
            returnNode = node != null ? CheckNode(node.LeftNode, value) : null;
            if (returnNode != null)
            {
                return returnNode;
            }
            returnNode = node != null ? CheckNode(node.RightNode, value) : null;
            return returnNode;
        }

        private BinaryTreeNode<T> NodeValueEquals(BinaryTreeNode<T> node, int value)
        {
            if (node != null && node.Value.Equals(value))
            {
                return node;
            }
            return null;
        }
    }
}
