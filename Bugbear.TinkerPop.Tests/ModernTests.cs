using Bugbear.Graph.SimpleGraphDB;
using NUnit.Framework;

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
    }
}