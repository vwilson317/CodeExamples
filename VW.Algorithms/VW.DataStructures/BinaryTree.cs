using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW.DataStructures
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public Node Find(int value)
        {
            if (Root.Value.Equals(value))
                return Root;

            var matchingNode = CheckNode(Root, value);
            return matchingNode;
        }

        private Node CheckNode(Node node, int value)
        {
            if (node != null && node.Value.Equals(value))
            {
                return node;
            }

            var leftNode = node?.LeftNode != null ? CheckNode(node.LeftNode, value) : null;
            if (leftNode != null && leftNode.Value.Equals(value))
            {
                return leftNode;
            }

            var rightNode = node?.RightNode != null ? CheckNode(node.RightNode, value) : null;
            if (rightNode != null && rightNode.Value.Equals(value))
            {
                return rightNode;
            }

            return null;
        }
    }
}
