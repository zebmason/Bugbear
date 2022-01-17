using Gremlin.Net.Structure;

namespace Bugbear.Core.Graph
{
    public interface IBuilder<U>
    {
        U ToBuild { get; }
    }

    public interface IVertexBuilder : IBuilder<Vertex>
    {
        IVertexBuilder Add(string label, dynamic value);

        IEdgeBuilder AddEdge(string label, IVertexBuilder other, object id);
    }

    public interface IEdgeBuilder : IBuilder<Edge>
    {
        IEdgeBuilder Add(string label, dynamic value);
    }
}
