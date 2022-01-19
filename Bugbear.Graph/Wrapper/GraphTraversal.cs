using Bugbear.Core.Wrapper;
using Gremlin.Net.Structure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bugbear.Graph.Wrapper
{
    public class GraphTraversal<S, E> : IGraphTraversal<S, E>
    {
        private readonly IGraphDB _graph;
        private readonly IReadOnlyList<E> _selection;

        public GraphTraversal(IGraphDB graph, IReadOnlyList<E> selection)
        {
            _graph = graph;
            _selection = selection;
        }

        public override string ToString()
        {
            return string.Join(" \n", _selection);
        }
        public IGraphTraversal<S, E> Has(string propertyKey, object value)
        {
            if (_selection is List<Vertex> vertices)
            {
                var props = _graph.VertexProps(propertyKey);
                var narrowed = new List<Vertex>();
                foreach (var vertex in vertices)
                {
                    if (props.TryGetValue(vertex, out VertexProperty prop) && prop.Value == value)
                    {
                        narrowed.Add(vertex);
                    }
                }

                return new GraphTraversal<S, E>(_graph, narrowed as List<E>);
            }

            if (_selection is List<Edge> edges)
            {
                var props = _graph.EdgeProps(propertyKey);
                var narrowed = new List<Edge>();
                foreach (var edge in edges)
                {
                    if (props.TryGetValue(edge, out Property prop) && prop.Value == value)
                    {
                        narrowed.Add(edge);
                    }
                }

                return new GraphTraversal<S, E>(_graph, narrowed as List<E>);
            }

            throw new ArgumentException("Selection is not of type Vertex or Edge");
        }

        public IGraphTraversal<S, Vertex> Out(params string[] edgeLabels)
        {
            return OutE(edgeLabels).OutV();
        }

        public IGraphTraversal<S, Edge> OutE(params string[] edgeLabels)
        {
            if (_selection is List<Vertex> vertices)
            {
                var edges = new List<Edge>();
                if (edgeLabels.Length == 0)
                {
                    foreach (var edge in _graph.Edges())
                    {
                        if (vertices.Contains(edge.OutV))
                        {
                            edges.Add(edge);
                        }
                    }
                }
                else
                {
                    foreach (var edge in _graph.Edges())
                    {
                        if (vertices.Contains(edge.OutV) && edgeLabels.Contains(edge.Label))
                        {
                            edges.Add(edge);
                        }
                    }
                }

                return new GraphTraversal<S, Edge>(_graph, edges);
            }

            throw new ArgumentException("Selection is not of type Vertex");
        }

        public IGraphTraversal<S, Vertex> OutV()
        {
            if (_selection is List<Edge> edges)
            {
                var vertices = new List<Vertex>();
                foreach (var edge in edges)
                {
                    vertices.Add(edge.InV);
                }

                return new GraphTraversal<S, Vertex>(_graph, vertices);
            }

            throw new ArgumentException("Selection is not of type Edge");
        }

        public IGraphTraversal<S, E2> Values<E2>(params string[] propertyKeys)
        {
            var values = new List<E2>();
            if (_selection is List<Vertex> vertices)
            {
                foreach (var key in propertyKeys)
                {
                    var properties = _graph.VertexProps(key);
                    foreach (var vertex in vertices)
                    {
                        if (properties.TryGetValue(vertex, out VertexProperty property))
                        {
                            values.Add(property.Value);
                        }
                    }
                }

                return new GraphTraversal<S, E2>(_graph, values);
            }

            if (_selection is List<Edge> edges)
            {
                foreach (var key in propertyKeys)
                {
                    var properties = _graph.EdgeProps(key);
                    foreach (var edge in edges)
                    {
                        if (properties.TryGetValue(edge, out Property property))
                        {
                            values.Add(property.Value);
                        }
                    }
                }

                return new GraphTraversal<S, E2>(_graph, values);
            }

            throw new ArgumentException("Selection is not of type Vertex or Edge");
        }
    }
}
