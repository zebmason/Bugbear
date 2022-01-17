using Bugbear.Core.Graph;

namespace Bugbear.TinkerPop
{
    public static class TinkerFactory
    {
        public static void CreateModern(IGraphDB graph)
        {
            var marko = graph.AddVertex(1, "person").Add("name", "marko").Add("age", 29);
            var vadas = graph.AddVertex(2, "person").Add("name", "vadas").Add("age", 27);
            var lop = graph.AddVertex(3, "software").Add("name", "lop").Add("lang", "java");
            var josh = graph.AddVertex(4, "person").Add("name", "josh").Add("age", 32);
            var ripple = graph.AddVertex(5, "software").Add("name", "ripple").Add("lang", "java");
            var peter = graph.AddVertex(6, "person").Add("name", "peter").Add("age", 35);

            marko.AddEdge("knows", vadas, 7).Add("weight", 0.5d);
            marko.AddEdge("knows", josh, 8).Add("weight", 1.0d);
            marko.AddEdge("created", lop, 9).Add("weight", 0.4d);
            josh.AddEdge("created", ripple, 10).Add("weight", 1.0d);
            josh.AddEdge("created", lop, 11).Add("weight", 0.4d);
            peter.AddEdge("created", lop, 12).Add("weight", 0.2d);
        }
    }
}
