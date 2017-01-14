namespace VW.DataStructures
{
    public class BinaryTreeNode<TNode> : Node<TNode>
    {
        public BinaryTreeNode<TNode> LeftNode { get; set; }
        public BinaryTreeNode<TNode> RightNode { get; set; }

        public BinaryTreeNode(TNode value) : base(value)
        {
        }
    }
}