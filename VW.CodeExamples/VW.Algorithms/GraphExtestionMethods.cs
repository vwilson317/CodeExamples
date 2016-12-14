using System.Collections.Generic;
using System.Linq;
using VW.DataStructures;

namespace VW.Algorithms
{
    public static class GraphExtestionMethods
    {
        public static GraphNode<int> FindBreadthFirst(this Graph<int> graph, int searchVal)
        {
            return null;
        }

        public static GraphNode<int> FindDepthFirst(this Graph<int> graph, int searchVal)
        {
            return null;
        }

        public static int[] TraverseBreadthFirst(this GraphNode<int> startingNode)
        {
            var visited = new Dictionary<GraphNode<int>, GraphNode<int>>();
            var returnVal = new Queue<GraphNode<int>>();
            visited.Add(startingNode, startingNode);
            DiscoverNode(startingNode, visited, returnVal);

            return visited.Values.Select(x => x.Value).ToArray();
        }

        private static void DiscoverNode(GraphNode<int> vertice,
            Dictionary<GraphNode<int>, GraphNode<int>> visited, Queue<GraphNode<int>> nodeTracker)
        {
            foreach (var currentNode in vertice.AdjacentNodes)
            {
                if (!visited.ContainsKey(currentNode))
                {
                    nodeTracker.Enqueue(currentNode);
                    visited.Add(currentNode, currentNode);
                }
            }

            if (nodeTracker.Count > 0)
            {
                DiscoverNode(nodeTracker.Dequeue(), visited, nodeTracker);
            }
        }

        public static int[] TraverseDepthFirst(this GraphNode<int> startVertice)
        {
            var parentNodes = new Stack<GraphNode<int>>();
            LinkedList<int> result = new LinkedList<int>();
            parentNodes.Push(startVertice);
            result.AddFirst(startVertice.Value);
            DiscoverNode(startVertice, parentNodes, result);

            return result.Select(x => x).ToArray();
        }

        public static void DiscoverNode(GraphNode<int> node, Stack<GraphNode<int>> parents, LinkedList<int> visited)
        {
            foreach (var currentNode in node.AdjacentNodes)
            {
                if (!visited.Contains(currentNode.Value))
                {
                    visited.AddLast(currentNode.Value);
                    parents.Push(currentNode);
                }
                if (parents.Count > 0)
                {
                    DiscoverNode(parents.Pop(), parents, visited);
                }
            }
        }
    }
}
