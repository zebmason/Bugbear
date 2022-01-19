using Gremlin.Net.Structure;

namespace Bugbear.Core.Graph
{
    public interface IBuildGraphDB
    {
        #region Builders
        IVertexBuilder AddVertex(object id, string label);

        IEdgeBuilder AddEdge(object id, Vertex outV, string label, Vertex inV);

        void AddVertexProperty(Vertex item, string label, dynamic value);

        void AddEdgeProperty(Edge item, string label, dynamic value);
        #endregion
    }
}
