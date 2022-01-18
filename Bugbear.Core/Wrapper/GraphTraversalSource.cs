using Gremlin.Net.Structure;

namespace Bugbear.Core.Wrapper
{
    public class GraphTraversalSource : IGraphTraversalSource
    {
        private readonly Gremlin.Net.Process.Traversal.GraphTraversalSource _source;

        public GraphTraversalSource(Gremlin.Net.Process.Traversal.GraphTraversalSource source)
        {
            _source = source;
        }

        public IGraphTraversal<Vertex, Vertex> V(params object[] vertexIds)
        {
            return new GraphTraversal<Vertex, Vertex>(_source.V(vertexIds));
        }
    }
}
