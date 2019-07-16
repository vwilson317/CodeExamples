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

        /// <summary>
        /// Google interview question 12/14/2016
        /// Important note: Use a dictionary to store visited node by using the original as the key and copy as the value
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static GraphNode<int> Copy(this GraphNode<int> node)
        {
            var visitedDict =  new Dictionary<GraphNode<int>, GraphNode<int>>();
            var result = DoCopy(node, visitedDict);
            return result;
        }

        private static GraphNode<int> DoCopy(GraphNode<int> nodeOrg, Dictionary<GraphNode<int>, GraphNode<int>> visitedNodes)
        {
            var nodeCopy = new GraphNode<int>(nodeOrg.Value);
            visitedNodes.Add(nodeOrg, nodeCopy);
            foreach (var currentNode in nodeOrg.AdjacentNodes)
            {
                if (!visitedNodes.ContainsKey(currentNode))
                {
                    nodeCopy.AdjacentNodes.Add(DoCopy(currentNode, visitedNodes));
                }
                else
                {
                    nodeCopy.AdjacentNodes.Add(visitedNodes[currentNode]);
                }
            }

            return nodeCopy;
        } 
    }
}
