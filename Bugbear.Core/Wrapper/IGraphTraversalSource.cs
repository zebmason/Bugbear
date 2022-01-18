using Gremlin.Net.Structure;

namespace Bugbear.Core.Wrapper
{
    public interface IGraphTraversalSource
    {
        IGraphTraversal<Vertex, Vertex> V(params object[] vertexIds);
    }
}
