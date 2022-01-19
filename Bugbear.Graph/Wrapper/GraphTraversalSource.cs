using Bugbear.Core.Wrapper;
using Gremlin.Net.Structure;

namespace Bugbear.Graph.Wrapper
{
    public class GraphTraversalSource : IGraphTraversalSource
    {
        private readonly IGraphDB _graph;

        public GraphTraversalSource(IGraphDB graph)
        {
            _graph = graph;
        }

        public IGraphTraversal<Vertex, Vertex> V(params object[] vertexIds)
        {
            return new GraphTraversal<Vertex, Vertex>(_graph, _graph.Vertices(vertexIds));
        }
    }
}
