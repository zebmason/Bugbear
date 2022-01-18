using Bugbear.Graph.SimpleGraphDB;
using Bugbear.Graph.Wrapper;
using NUnit.Framework;
using System.Linq;

namespace Bugbear.TinkerPop.Tests
{
    public class ModernTests
    {
        [Test]
        public void TestToString()
        {
            var graph = new GraphDB();
            TinkerFactory.CreateModern(graph);
            Assert.AreEqual("GraphDB[vertices:6 edges:6]", graph.ToString());
        }

        [Test]
        public void TestWhoMarkoKnows()
        {
            var graph = new GraphDB();
            TinkerFactory.CreateModern(graph);
            var g = new GraphTraversalSource(graph);
            var names = g.V().Has("name", "marko").Out("knows").Values<string>("name").ToString().Split(" \n");
            Assert.IsTrue(names.Contains("vadas"));
            Assert.IsTrue(names.Contains("josh"));
        }
    }
}