using System;
using System.Collections;
using System.Collections.Generic;

namespace VW.DataStructures
{
    public class Graph<T>
    {
        public List<GraphNode<T>> Vertices; 

        public Graph()
        {
            Vertices = new List<GraphNode<T>>();
        }

        public Graph(List<GraphNode<T>> vertices)
        {
            Vertices = vertices;
        }

        public void AddUndirectionalEdge(GraphNode<T> fromNode, GraphNode<T> toNode)
        {
            fromNode.AdjacentNodes.Add(toNode);
        }

        public void AddUndirectionalEdge(GraphNode<T> fromNode, GraphNode<T> toNode, int weight)
        {
            fromNode.AdjacentNodes.Add(toNode);
            fromNode.Edges.Add(toNode, weight);
        }
    }
}
