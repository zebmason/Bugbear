using Gremlin.Net.Structure;

namespace Bugbear.Core.Graph
{
    public class Builder<U> : IBuilder<U>
    {
        public U ToBuild { get; }
        protected readonly IBuildGraphDB _graph;

        public Builder(U vertex, IBuildGraphDB graph)
        {
            ToBuild = vertex;
            _graph = graph;
        }
    }

    public class VertexBuilder : Builder<Vertex>, IVertexBuilder
    {
        public VertexBuilder(Vertex vertex, IBuildGraphDB graph)
            : base(vertex, graph)
        {
        }

        public IVertexBuilder Add(string label, dynamic value)
        {
            _graph.AddVertexProperty(ToBuild, label, value);
            return this;
        }

        public IEdgeBuilder AddEdge(string label, IVertexBuilder other, object id)
        {
            return _graph.AddEdge(id, ToBuild, label, other.ToBuild);
        }
    }

    public class EdgeBuilder : Builder<Edge>, IEdgeBuilder
    {
        public EdgeBuilder(Edge edge, IBuildGraphDB graph)
            : base(edge, graph)
        {
        }

        public IEdgeBuilder Add(string label, dynamic value)
        {
            _graph.AddEdgeProperty(ToBuild, label, value);
            return this;
        }
    }
}
