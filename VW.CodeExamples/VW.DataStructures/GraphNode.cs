using System.Collections.Generic;

namespace VW.DataStructures
{
    public class GraphNode<T>: Node<T>
    {
        public List<GraphNode<T>> AdjacentNodes = new List<GraphNode<T>>();
        public Dictionary<GraphNode<T>, int> Edges = new Dictionary<GraphNode<T>, int>();

        public GraphNode(T value) : base(value)
        {
        }
    }
}