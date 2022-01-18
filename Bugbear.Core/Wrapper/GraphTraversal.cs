using Gremlin.Net.Structure;

namespace Bugbear.Core.Wrapper
{
    public class GraphTraversal<S, E> : IGraphTraversal<S, E>
    {
        private readonly Gremlin.Net.Process.Traversal.GraphTraversal<S, E> _gremlin;

        public GraphTraversal(Gremlin.Net.Process.Traversal.GraphTraversal<S, E> gremlin)
        {
            _gremlin = gremlin;
        }

        public IGraphTraversal<S, E> Has(string propertyKey, object value)
        {
            return new GraphTraversal<S, E>(_gremlin.Has(propertyKey, value));
        }

        public IGraphTraversal<S, Vertex> Out(params string[] edgeLabels)
        {
            return new GraphTraversal<S, Vertex>(_gremlin.Out(edgeLabels));
        }

        public IGraphTraversal<S, Edge> OutE(params string[] edgeLabels)
        {
            return new GraphTraversal<S, Edge>(_gremlin.OutE(edgeLabels));
        }

        public IGraphTraversal<S, Vertex> OutV()
        {
            return new GraphTraversal<S, Vertex>(_gremlin.OutV());
        }

        public IGraphTraversal<S, E2> Values<E2>(params string[] propertyKeys)
        {
            return new GraphTraversal<S, E2>(_gremlin.Values<E2>(propertyKeys));
        }
    }
}
