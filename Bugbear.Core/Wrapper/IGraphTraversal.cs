using Gremlin.Net.Structure;

namespace Bugbear.Core.Wrapper
{
    public interface IGraphTraversal<S, E>
    {
        IGraphTraversal<S, E> Has(string propertyKey, object value);
        IGraphTraversal<S, Vertex> Out(params string[] edgeLabels);
        IGraphTraversal<S, Edge> OutE(params string[] edgeLabels);
        IGraphTraversal<S, Vertex> OutV();
        IGraphTraversal<S, E2> Values<E2>(params string[] propertyKeys);
    }
}
