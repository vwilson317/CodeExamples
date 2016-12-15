using System.Collections.Generic;

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

        public List<BinaryTreeNode<T>> DeleteNodes(HashSet<BinaryTreeNode<T>> nodesToDelete)
        {
            var rootNodes = new List<BinaryTreeNode<T>>();
            DoDelete(Root, nodesToDelete, rootNodes);

            return rootNodes;
        }

        private void DoDelete(BinaryTreeNode<T> currentNode, HashSet<BinaryTreeNode<T>> nodesToDelete,
            List<BinaryTreeNode<T>> rootNodes)
        {
            if (nodesToDelete.Contains(currentNode))
            {
                if (currentNode.LeftNode != null)
                {
                    rootNodes.Add(currentNode.LeftNode);
                }
                if (currentNode.RightNode != null)
                {
                    rootNodes.Add(currentNode.RightNode);
                }
            }

            if (currentNode.LeftNode != null)
            {
                DoDelete(currentNode.LeftNode, nodesToDelete, rootNodes);
            }
            if (currentNode.RightNode != null)
            {
                DoDelete(currentNode.RightNode, nodesToDelete, rootNodes);
            }
        }
    }
}
