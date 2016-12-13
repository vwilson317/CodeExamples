using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using VW.Algorithms;
using VW.DataStructures;

namespace VW.Tests
{
    [TestFixture]
    public class GraphTests
    {
        public Graph<int> MyGraph;

        [SetUp]
        public void Setup()
        {
            var nodeList = new List<GraphNode<int>>
            {
                new GraphNode<int>(4),
                new GraphNode<int>(0),
                new GraphNode<int>(5),
                new GraphNode<int>(1),
                new GraphNode<int>(7),
                new GraphNode<int>(10),
                new GraphNode<int>(8),
                new GraphNode<int>(6),
            };
            MyGraph = new Graph<int>(nodeList);

            MyGraph.AddUndirectionalEdge(nodeList[0], nodeList[1]);
            MyGraph.AddUndirectionalEdge(nodeList[0], nodeList[2]);
            MyGraph.AddUndirectionalEdge(nodeList[2], nodeList[2]);
            MyGraph.AddUndirectionalEdge(nodeList[2], nodeList[3]);
            MyGraph.AddUndirectionalEdge(nodeList[2], nodeList[4]);
            MyGraph.AddUndirectionalEdge(nodeList[2], nodeList[5]);
            MyGraph.AddUndirectionalEdge(nodeList[3], nodeList[6]);
            MyGraph.AddUndirectionalEdge(nodeList[4], nodeList[6]);
            MyGraph.AddUndirectionalEdge(nodeList[5], nodeList[7]);
        }

        [Test]
        public void Validate_BreadfirstTraversal()
        {
            //Act
            var actualTraversalResults = MyGraph.Vertices.First().TraverseBreadthFirst();

            //Assert
            var expectedTraversalResults = new[] { 4, 0, 5, 1, 7, 10, 8, 6 };
            actualTraversalResults.Should().Equal(expectedTraversalResults);
        }

        [Test]
        public void Validate_DepthfirstTraversal()
        {
            //Act
            var actualTraversalResults = MyGraph.Vertices.First().TraverseDepthFirst();

            //Assert
            var expectedTraversalResults = new[] { 4, 0, 5, 1, 8, 7, 10, 6 };
            actualTraversalResults.Should().Equal(expectedTraversalResults);
        }

        private void SetupDepthFirstGraph()
        {

        }
    }
}
