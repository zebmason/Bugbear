#region License

/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

#endregion

using Gremlin.Net.Structure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bugbear.Graph.Wrapper
{
    public class GraphTraversal<S, E> : Gremlin.Net.Process.Traversal.GraphTraversal<S, E>
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

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Edge> AddE(string edgeLabel)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Edge> AddE(Gremlin.Net.Process.Traversal.ITraversal edgeLabelTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Vertex> AddV()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Vertex> AddV(string vertexLabel)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Vertex> AddV(Gremlin.Net.Process.Traversal.ITraversal vertexLabelTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Aggregate(Gremlin.Net.Process.Traversal.Scope scope, string sideEffectKey)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Aggregate(string sideEffectKey)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> And(params Gremlin.Net.Process.Traversal.ITraversal[] andTraversals)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> As(string stepLabel, params string[] stepLabels)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Barrier()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Barrier(Gremlin.Net.Process.Traversal.IConsumer barrierConsumer)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Barrier(int maxBarrierSize)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Vertex> Both(params string[] edgeLabels)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Edge> BothE(params string[] edgeLabels)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Vertex> BothV()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Branch<E2>(Gremlin.Net.Process.Traversal.IFunction function)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Branch<E2>(Gremlin.Net.Process.Traversal.ITraversal branchTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> By(string key, Gremlin.Net.Process.Traversal.IComparator comparator)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> By()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> By(Gremlin.Net.Process.Traversal.IComparator comparator)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> By(Gremlin.Net.Process.Traversal.IFunction function)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> By(Gremlin.Net.Process.Traversal.IFunction function, Gremlin.Net.Process.Traversal.IComparator comparator)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> By(Gremlin.Net.Process.Traversal.Order order)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> By(string key)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> By(Gremlin.Net.Process.Traversal.T token)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> By(Gremlin.Net.Process.Traversal.ITraversal traversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> By(Gremlin.Net.Process.Traversal.ITraversal traversal, Gremlin.Net.Process.Traversal.IComparator comparator)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Cap<E2>(string sideEffectKey, params string[] sideEffectKeys)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Choose<E2>(Gremlin.Net.Process.Traversal.IPredicate choosePredicate, Gremlin.Net.Process.Traversal.ITraversal trueChoice, Gremlin.Net.Process.Traversal.ITraversal falseChoice)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Choose<E2>(Gremlin.Net.Process.Traversal.IPredicate choosePredicate, Gremlin.Net.Process.Traversal.ITraversal trueChoice)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Choose<E2>(Gremlin.Net.Process.Traversal.ITraversal choiceTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Choose<E2>(Gremlin.Net.Process.Traversal.ITraversal traversalPredicate, Gremlin.Net.Process.Traversal.ITraversal trueChoice, Gremlin.Net.Process.Traversal.ITraversal falseChoice)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Choose<E2>(Gremlin.Net.Process.Traversal.IFunction choiceFunction)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Choose<E2>(Gremlin.Net.Process.Traversal.ITraversal traversalPredicate, Gremlin.Net.Process.Traversal.ITraversal trueChoice)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Clone()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Coalesce<E2>(params Gremlin.Net.Process.Traversal.ITraversal[] coalesceTraversals)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Coin(double probability)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> ConnectedComponent()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Constant<E2>(E2 e)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, long> Count()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, long> Count(Gremlin.Net.Process.Traversal.Scope scope)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> CyclicPath()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Dedup(Gremlin.Net.Process.Traversal.Scope scope, params string[] dedupLabels)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Dedup(params string[] dedupLabels)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Drop()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, IDictionary<object, E2>> ElementMap<E2>(params string[] propertyKeys)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Emit()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Emit(Gremlin.Net.Process.Traversal.IPredicate emitPredicate)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Emit(Gremlin.Net.Process.Traversal.ITraversal emitTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Filter(Gremlin.Net.Process.Traversal.ITraversal filterTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Filter(Gremlin.Net.Process.Traversal.IPredicate predicate)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> FlatMap<E2>(Gremlin.Net.Process.Traversal.IFunction function)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> FlatMap<E2>(Gremlin.Net.Process.Traversal.ITraversal flatMapTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, IList<E>> Fold()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Fold<E2>(E2 seed, Gremlin.Net.Process.Traversal.IBiFunction foldFunction)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> From(string fromStepLabel)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> From(Gremlin.Net.Process.Traversal.ITraversal fromVertex)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> From(Vertex fromVertex)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, IDictionary<K, V>> Group<K, V>()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Group(string sideEffectKey)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, IDictionary<K, long>> GroupCount<K>()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> GroupCount(string sideEffectKey)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Has(Gremlin.Net.Process.Traversal.T accessor, object value)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Has(Gremlin.Net.Process.Traversal.T accessor, Gremlin.Net.Process.Traversal.ITraversal propertyTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Has(Gremlin.Net.Process.Traversal.T accessor, Gremlin.Net.Process.Traversal.P predicate)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Has(string propertyKey, Gremlin.Net.Process.Traversal.ITraversal propertyTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Has(string propertyKey)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Has(string label, string propertyKey, object value)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Has(string propertyKey, Gremlin.Net.Process.Traversal.P predicate)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Has(string propertyKey, object value)
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

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Has(string label, string propertyKey, Gremlin.Net.Process.Traversal.P predicate)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> HasId(object id, params object[] otherIds)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> HasId(Gremlin.Net.Process.Traversal.P predicate)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> HasKey(Gremlin.Net.Process.Traversal.P predicate)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> HasKey(string label, params string[] otherLabels)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> HasLabel(Gremlin.Net.Process.Traversal.P predicate)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> HasLabel(string label, params string[] otherLabels)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> HasNot(string propertyKey)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> HasValue(Gremlin.Net.Process.Traversal.P predicate)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> HasValue(object value, params object[] otherValues)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, object> Id()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Identity()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Vertex> In(params string[] edgeLabels)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Index<E2>()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Edge> InE(params string[] edgeLabels)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Inject(params E[] injections)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Vertex> InV()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Is(object value)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Is(Gremlin.Net.Process.Traversal.P predicate)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, string> Key()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, string> Label()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Limit<E2>(Gremlin.Net.Process.Traversal.Scope scope, long limit)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Limit<E2>(long limit)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Local<E2>(Gremlin.Net.Process.Traversal.ITraversal localTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, int> Loops()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, int> Loops(string loopName)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Map<E2>(Gremlin.Net.Process.Traversal.IFunction function)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Map<E2>(Gremlin.Net.Process.Traversal.ITraversal mapTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, IDictionary<string, E2>> Match<E2>(params Gremlin.Net.Process.Traversal.ITraversal[] matchTraversals)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, double> Math(string expression)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Max<E2>()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Max<E2>(Gremlin.Net.Process.Traversal.Scope scope)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Mean<E2>()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Mean<E2>(Gremlin.Net.Process.Traversal.Scope scope)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Min<E2>()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Min<E2>(Gremlin.Net.Process.Traversal.Scope scope)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Not(Gremlin.Net.Process.Traversal.ITraversal notTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Option(object pickToken, Gremlin.Net.Process.Traversal.ITraversal traversalOption)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Option(Gremlin.Net.Process.Traversal.ITraversal traversalOption)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Optional<E2>(Gremlin.Net.Process.Traversal.ITraversal optionalTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Or(params Gremlin.Net.Process.Traversal.ITraversal[] orTraversals)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Order()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Order(Gremlin.Net.Process.Traversal.Scope scope)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Vertex> OtherV()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Vertex> Out(params string[] edgeLabels)
        {
            return OutE(edgeLabels).OutV();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Edge> OutE(params string[] edgeLabels)
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

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Vertex> OutV()
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

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> PageRank()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> PageRank(double alpha)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Path> Path()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> PeerPressure()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Profile(string sideEffectKey)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Profile<E2>()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Program(object vertexProgram)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, IDictionary<string, E2>> Project<E2>(string projectKey, params string[] otherProjectKeys)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Properties<E2>(params string[] propertyKeys)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Property(Gremlin.Net.Process.Traversal.Cardinality cardinality, object key, object value, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Property(object key, object value, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, IDictionary<string, E2>> PropertyMap<E2>(params string[] propertyKeys)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Range<E2>(Gremlin.Net.Process.Traversal.Scope scope, long low, long high)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Range<E2>(long low, long high)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Read()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Repeat(string loopName, Gremlin.Net.Process.Traversal.ITraversal repeatTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Repeat(Gremlin.Net.Process.Traversal.ITraversal repeatTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Sack<E2>()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Sack(Gremlin.Net.Process.Traversal.IBiFunction sackOperator)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Sample(int amountToSample)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Sample(Gremlin.Net.Process.Traversal.Scope scope, int amountToSample)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, ICollection<E2>> Select<E2>(Gremlin.Net.Process.Traversal.Column column)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Select<E2>(Gremlin.Net.Process.Traversal.Pop pop, string selectKey)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, IDictionary<string, E2>> Select<E2>(Gremlin.Net.Process.Traversal.Pop pop, string selectKey1, string selectKey2, params string[] otherSelectKeys)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Select<E2>(Gremlin.Net.Process.Traversal.Pop pop, Gremlin.Net.Process.Traversal.ITraversal keyTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Select<E2>(string selectKey)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, IDictionary<string, E2>> Select<E2>(string selectKey1, string selectKey2, params string[] otherSelectKeys)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Select<E2>(Gremlin.Net.Process.Traversal.ITraversal keyTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Path> ShortestPath()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> SideEffect(Gremlin.Net.Process.Traversal.IConsumer consumer)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> SideEffect(Gremlin.Net.Process.Traversal.ITraversal sideEffectTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> SimplePath()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Skip<E2>(Gremlin.Net.Process.Traversal.Scope scope, long skip)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Skip<E2>(long skip)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Store(string sideEffectKey)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Edge> Subgraph(string sideEffectKey)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Sum<E2>()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Sum<E2>(Gremlin.Net.Process.Traversal.Scope scope)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Tail<E2>()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Tail<E2>(Gremlin.Net.Process.Traversal.Scope scope)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Tail<E2>(Gremlin.Net.Process.Traversal.Scope scope, long limit)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Tail<E2>(long limit)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> TimeLimit(long timeLimit)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Times(int maxLoops)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Vertex> To(Gremlin.Net.Process.Traversal.Direction direction, params string[] edgeLabels)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> To(string toStepLabel)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> To(Gremlin.Net.Process.Traversal.ITraversal toVertex)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> To(Vertex toVertex)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Edge> ToE(Gremlin.Net.Process.Traversal.Direction direction, params string[] edgeLabels)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Vertex> ToV(Gremlin.Net.Process.Traversal.Direction direction)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Tree<E2>()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Tree(string sideEffectKey)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Unfold<E2>()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Union<E2>(params Gremlin.Net.Process.Traversal.ITraversal[] unionTraversals)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Until(Gremlin.Net.Process.Traversal.ITraversal untilTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Until(Gremlin.Net.Process.Traversal.IPredicate untilPredicate)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, Vertex> V(params object[] vertexIdsOrElements)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Value<E2>()
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, IDictionary<TKey, TValue>> ValueMap<TKey, TValue>(params string[] propertyKeys)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, IDictionary<TKey, TValue>> ValueMap<TKey, TValue>(bool includeTokens, params string[] propertyKeys)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E2> Values<E2>(params string[] propertyKeys)
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

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Where(Gremlin.Net.Process.Traversal.P predicate)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Where(string startKey, Gremlin.Net.Process.Traversal.P predicate)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Where(Gremlin.Net.Process.Traversal.ITraversal whereTraversal)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> With(string key)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> With(string key, object value)
        {
            throw new NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, E> Write()
        {
            throw new NotImplementedException();
        }
    }
}
