using Bugbear.Core.Graph;
using Bugbear.Graph.Wrapper;
using Gremlin.Net.Structure;
using System.Collections.Generic;
using System.Linq;

namespace Bugbear.Graph.SimpleGraphDB
{
    public class GraphDB : IGraphDB
    {
        private readonly List<Vertex> _vertices = new List<Vertex>();
        private readonly List<Edge> _edges = new List<Edge>();
        private readonly Dictionary<string, Dictionary<object, VertexProperty>> _vertexProps = new Dictionary<string, Dictionary<object, VertexProperty>>();
        private readonly Dictionary<string, Dictionary<object, Property>> _edgeProps = new Dictionary<string, Dictionary<object, Property>>();

        public GraphDB()
        {
        }

        public override string ToString()
        {
            return $"GraphDB[vertices:{_vertices.Count} edges:{_edges.Count}]";
        }

        #region Getters
        public IReadOnlyList<Vertex> Vertices(params object[] vertexIds)
        {
            if (vertexIds.Length == 0)
                return _vertices;

            var vertices = new List<Vertex>();
            foreach (var vertex in _vertices)
            {
                if (!vertexIds.Contains(vertex.Id))
                {
                    vertices.Add(vertex);
                }
            }

            return vertices;
        }

        public IReadOnlyList<Edge> Edges(params object[] edgeIds)
        {
            if (edgeIds.Length == 0)
                return _edges;

            var edges = new List<Edge>();
            foreach (var edge in _edges)
            {
                if (!edgeIds.Contains(edge.Id))
                {
                    edges.Add(edge);
                }
            }

            return edges;
        }

        public IReadOnlyDictionary<object, VertexProperty> VertexProps(string propertyKey)
        {
            return _vertexProps[propertyKey];
        }

        public IReadOnlyDictionary<object, Property> EdgeProps(string propertyKey)
        {
            return _edgeProps[propertyKey];
        }
        #endregion

        #region Builders
        public IVertexBuilder AddVertex(object id, string label)
        {
            var vertex = new Vertex(id, label);
            _vertices.Add(vertex);
            return new VertexBuilder(vertex, this);
        }

        public IEdgeBuilder AddEdge(object id, Vertex outV, string label, Vertex inV)
        {
            var edge = new Edge(id, outV, label, inV);
            _edges.Add(edge);
            return new EdgeBuilder(edge, this);
        }

        public void AddVertexProperty(Vertex vertex, string label, dynamic value)
        {
            if (!_vertexProps.ContainsKey(label))
            {
                _vertexProps[label] = new Dictionary<object, VertexProperty>();
            }

            // \todo what is the first argument to VertexProperty?
            _vertexProps[label][vertex] = new VertexProperty(vertex.Id, label, value, vertex);
        }

        public void AddEdgeProperty(Edge edge, string label, dynamic value)
        {
            if (!_edgeProps.ContainsKey(label))
            {
                _edgeProps[label] = new Dictionary<object, Property>();
            }

            _edgeProps[label][edge] = new Property(label, value, edge);
        }
        #endregion
    }
}
