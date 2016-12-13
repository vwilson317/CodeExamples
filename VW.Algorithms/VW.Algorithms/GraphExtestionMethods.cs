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

        public static GraphNode<int> FindDeepthFirst(this Graph<int> graph, int searchVal)
        {
            return null;
        }

        public static int[] TraverseBreadthFirst(this GraphNode<int> startingNode)
        {
            var queue = new List<GraphNode<int>>();
            queue.Add(startingNode);
            DiscoverNode(startingNode, queue);

            return queue.Select(x => x.Value).ToArray();
        }

        private static void DiscoverNode(GraphNode<int> vertice, List<GraphNode<int>> queue)
        {
            foreach (var currentNode in vertice.AdjacentNodes)
            {
                if (!queue.Contains(currentNode))
                {
                    queue.Add(currentNode);
                    DiscoverNode(currentNode, queue);
                }
            }
        }
    }
}
