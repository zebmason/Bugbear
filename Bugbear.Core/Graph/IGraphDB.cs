using Gremlin.Net.Structure;
using System.Collections.Generic;

namespace Bugbear.Core.Graph
{
    public interface IGraphDB
    {
        #region Getters
        IReadOnlyList<Vertex> Vertices(params object[] vertexIds);

        IReadOnlyList<Edge> Edges(params object[] edgeIds);

        IReadOnlyDictionary<object, VertexProperty> VertexProps(string propertyKey);

        IReadOnlyDictionary<object, Property> EdgeProps(string propertyKey);
        #endregion

        #region Builders
        IVertexBuilder AddVertex(object id, string label);

        IEdgeBuilder AddEdge(object id, Vertex outV, string label, Vertex inV);

        void AddVertexProperty(Vertex item, string label, dynamic value);

        void AddEdgeProperty(Edge item, string label, dynamic value);
        #endregion
    }
}
