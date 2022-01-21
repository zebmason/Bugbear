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

using Bugbear.Core.Wrapper;
using Gremlin.Net.Process.Traversal;
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

        public IGraphTraversal<S, Edge> AddE(string edgeLabel)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, Edge> AddE(ITraversal edgeLabelTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, Vertex> AddV()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, Vertex> AddV(string vertexLabel)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, Vertex> AddV(ITraversal vertexLabelTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Aggregate(Scope scope, string sideEffectKey)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Aggregate(string sideEffectKey)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> And(params ITraversal[] andTraversals)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> As(string stepLabel, params string[] stepLabels)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Barrier()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Barrier(IConsumer barrierConsumer)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Barrier(int maxBarrierSize)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, Vertex> Both(params string[] edgeLabels)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, Edge> BothE(params string[] edgeLabels)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, Vertex> BothV()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Branch<E2>(IFunction function)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Branch<E2>(ITraversal branchTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> By(string key, IComparator comparator)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> By()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> By(IComparator comparator)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> By(IFunction function)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> By(IFunction function, IComparator comparator)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> By(Order order)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> By(string key)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> By(T token)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> By(ITraversal traversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> By(ITraversal traversal, IComparator comparator)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Cap<E2>(string sideEffectKey, params string[] sideEffectKeys)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Choose<E2>(IPredicate choosePredicate, ITraversal trueChoice, ITraversal falseChoice)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Choose<E2>(IPredicate choosePredicate, ITraversal trueChoice)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Choose<E2>(ITraversal choiceTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Choose<E2>(ITraversal traversalPredicate, ITraversal trueChoice, ITraversal falseChoice)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Choose<E2>(IFunction choiceFunction)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Choose<E2>(ITraversal traversalPredicate, ITraversal trueChoice)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Clone()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Coalesce<E2>(params ITraversal[] coalesceTraversals)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Coin(double probability)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> ConnectedComponent()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Constant<E2>(E2 e)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, long> Count()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, long> Count(Scope scope)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> CyclicPath()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Dedup(Scope scope, params string[] dedupLabels)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Dedup(params string[] dedupLabels)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Drop()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, IDictionary<object, E2>> ElementMap<E2>(params string[] propertyKeys)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Emit()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Emit(IPredicate emitPredicate)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Emit(ITraversal emitTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Filter(ITraversal filterTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Filter(IPredicate predicate)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> FlatMap<E2>(IFunction function)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> FlatMap<E2>(ITraversal flatMapTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, IList<E>> Fold()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Fold<E2>(E2 seed, IBiFunction foldFunction)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> From(string fromStepLabel)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> From(ITraversal fromVertex)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> From(Vertex fromVertex)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, IDictionary<K, V>> Group<K, V>()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Group(string sideEffectKey)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, IDictionary<K, long>> GroupCount<K>()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> GroupCount(string sideEffectKey)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Has(T accessor, object value)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Has(T accessor, ITraversal propertyTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Has(T accessor, IPredicate predicate)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Has(string propertyKey, ITraversal propertyTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Has(string propertyKey)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Has(string label, string propertyKey, object value)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Has(string propertyKey, IPredicate predicate)
        {
            throw new NotImplementedException();
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

        public IGraphTraversal<S, E> Has(string label, string propertyKey, IPredicate predicate)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> HasId(object id, params object[] otherIds)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> HasId(IPredicate predicate)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> HasKey(IPredicate predicate)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> HasKey(string label, params string[] otherLabels)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> HasLabel(IPredicate predicate)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> HasLabel(string label, params string[] otherLabels)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> HasNot(string propertyKey)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> HasValue(IPredicate predicate)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> HasValue(object value, params object[] otherValues)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, object> Id()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Identity()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, Vertex> In(params string[] edgeLabels)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Index<E2>()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, Edge> InE(params string[] edgeLabels)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Inject(params E[] injections)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, Vertex> InV()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Is(object value)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Is(IPredicate predicate)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, string> Key()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, string> Label()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Limit<E2>(Scope scope, long limit)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Limit<E2>(long limit)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Local<E2>(ITraversal localTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, int> Loops()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, int> Loops(string loopName)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Map<E2>(IFunction function)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Map<E2>(ITraversal mapTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, IDictionary<string, E2>> Match<E2>(params ITraversal[] matchTraversals)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, double> Math(string expression)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Max<E2>()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Max<E2>(Scope scope)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Mean<E2>()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Mean<E2>(Scope scope)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Min<E2>()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Min<E2>(Scope scope)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Not(ITraversal notTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Option(object pickToken, ITraversal traversalOption)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Option(ITraversal traversalOption)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Optional<E2>(ITraversal optionalTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Or(params ITraversal[] orTraversals)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Order()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Order(Scope scope)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, Vertex> OtherV()
        {
            throw new NotImplementedException();
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

        public IGraphTraversal<S, E> PageRank()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> PageRank(double alpha)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, Path> Path()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> PeerPressure()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Profile(string sideEffectKey)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Profile<E2>()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Program(object vertexProgram)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, IDictionary<string, E2>> Project<E2>(string projectKey, params string[] otherProjectKeys)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Properties<E2>(params string[] propertyKeys)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Property(Cardinality cardinality, object key, object value, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Property(object key, object value, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, IDictionary<string, E2>> PropertyMap<E2>(params string[] propertyKeys)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Range<E2>(Scope scope, long low, long high)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Range<E2>(long low, long high)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Read()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Repeat(string loopName, ITraversal repeatTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Repeat(ITraversal repeatTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Sack<E2>()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Sack(IBiFunction sackOperator)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Sample(int amountToSample)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Sample(Scope scope, int amountToSample)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, ICollection<E2>> Select<E2>(Column column)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Select<E2>(Pop pop, string selectKey)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, IDictionary<string, E2>> Select<E2>(Pop pop, string selectKey1, string selectKey2, params string[] otherSelectKeys)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Select<E2>(Pop pop, ITraversal keyTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Select<E2>(string selectKey)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, IDictionary<string, E2>> Select<E2>(string selectKey1, string selectKey2, params string[] otherSelectKeys)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Select<E2>(ITraversal keyTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, Path> ShortestPath()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> SideEffect(IConsumer consumer)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> SideEffect(ITraversal sideEffectTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> SimplePath()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Skip<E2>(Scope scope, long skip)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Skip<E2>(long skip)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Store(string sideEffectKey)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, Edge> Subgraph(string sideEffectKey)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Sum<E2>()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Sum<E2>(Scope scope)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Tail<E2>()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Tail<E2>(Scope scope)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Tail<E2>(Scope scope, long limit)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Tail<E2>(long limit)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> TimeLimit(long timeLimit)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Times(int maxLoops)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, Vertex> To(Direction direction, params string[] edgeLabels)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> To(string toStepLabel)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> To(ITraversal toVertex)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> To(Vertex toVertex)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, Edge> ToE(Direction direction, params string[] edgeLabels)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, Vertex> ToV(Direction direction)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Tree<E2>()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Tree(string sideEffectKey)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Unfold<E2>()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Union<E2>(params ITraversal[] unionTraversals)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Until(ITraversal untilTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Until(IPredicate untilPredicate)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, Vertex> V(params object[] vertexIdsOrElements)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E2> Value<E2>()
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, IDictionary<TKey, TValue>> ValueMap<TKey, TValue>(params string[] propertyKeys)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, IDictionary<TKey, TValue>> ValueMap<TKey, TValue>(bool includeTokens, params string[] propertyKeys)
        {
            throw new NotImplementedException();
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

        public IGraphTraversal<S, E> Where(IPredicate predicate)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Where(string startKey, IPredicate predicate)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Where(ITraversal whereTraversal)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> With(string key)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> With(string key, object value)
        {
            throw new NotImplementedException();
        }

        public IGraphTraversal<S, E> Write()
        {
            throw new NotImplementedException();
        }
    }
}
