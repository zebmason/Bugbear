using Bugbear.Core.Graph;
using Gremlin.Net.Structure;
using System.Collections.Generic;

namespace Bugbear.Graph.Wrapper
{
    public interface IGraphDB : IBuildGraphDB
    {
        #region Getters
        IReadOnlyList<Vertex> Vertices(params object[] vertexIds);

        IReadOnlyList<Edge> Edges(params object[] edgeIds);

        IReadOnlyDictionary<object, VertexProperty> VertexProps(string propertyKey);

        IReadOnlyDictionary<object, Property> EdgeProps(string propertyKey);
        #endregion
    }
}
