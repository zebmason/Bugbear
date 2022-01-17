using Bugbear.Core.Graph;
using Gremlin.Net.Structure;
using System.Collections.Generic;

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
    }
}
