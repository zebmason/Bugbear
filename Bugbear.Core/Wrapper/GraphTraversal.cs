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

using Gremlin.Net.Process.Traversal;
using Gremlin.Net.Structure;
using System.Collections.Generic;

namespace Bugbear.Core.Wrapper
{
    public class GraphTraversal<S, E> : IGraphTraversal<S, E>
    {
        private readonly Gremlin.Net.Process.Traversal.GraphTraversal<S, E> _gremlin;

        public GraphTraversal(Gremlin.Net.Process.Traversal.GraphTraversal<S, E> gremlin)
        {
            _gremlin = gremlin;
        }

        public IGraphTraversal<S, Edge> AddE(string edgeLabel)
        {
            return new GraphTraversal<S, Edge>(_gremlin.AddE(edgeLabel));
        }

        public IGraphTraversal<S, Edge> AddE(ITraversal edgeLabelTraversal)
        {
            return new GraphTraversal<S, Edge>(_gremlin.AddE(edgeLabelTraversal));
        }

        public IGraphTraversal<S, Vertex> AddV()
        {
            return new GraphTraversal<S, Vertex>(_gremlin.AddV());
        }

        public IGraphTraversal<S, Vertex> AddV(string vertexLabel)
        {
            return new GraphTraversal<S, Vertex>(_gremlin.AddV(vertexLabel));
        }

        public IGraphTraversal<S, Vertex> AddV(ITraversal vertexLabelTraversal)
        {
            return new GraphTraversal<S, Vertex>(_gremlin.AddV(vertexLabelTraversal));
        }

        public IGraphTraversal<S, E> Aggregate(Scope scope, string sideEffectKey)
        {
            return new GraphTraversal<S, E>(_gremlin.Aggregate(scope, sideEffectKey));
        }

        public IGraphTraversal<S, E> Aggregate(string sideEffectKey)
        {
            return new GraphTraversal<S, E>(_gremlin.Aggregate(sideEffectKey));
        }

        public IGraphTraversal<S, E> And(params ITraversal[] andTraversals)
        {
            return new GraphTraversal<S, E>(_gremlin.And(andTraversals));
        }

        public IGraphTraversal<S, E> As(string stepLabel, params string[] stepLabels)
        {
            return new GraphTraversal<S, E>(_gremlin.As(stepLabel, stepLabels));
        }

        public IGraphTraversal<S, E> Barrier()
        {
            return new GraphTraversal<S, E>(_gremlin.Barrier());
        }

        public IGraphTraversal<S, E> Barrier(IConsumer barrierConsumer)
        {
            return new GraphTraversal<S, E>(_gremlin.Barrier(barrierConsumer));
        }

        public IGraphTraversal<S, E> Barrier(int maxBarrierSize)
        {
            return new GraphTraversal<S, E>(_gremlin.Barrier(maxBarrierSize));
        }

        public IGraphTraversal<S, Vertex> Both(params string[] edgeLabels)
        {
            return new GraphTraversal<S, Vertex>(_gremlin.Both(edgeLabels));
        }

        public IGraphTraversal<S, Edge> BothE(params string[] edgeLabels)
        {
            return new GraphTraversal<S, Edge>(_gremlin.BothE(edgeLabels));
        }

        public IGraphTraversal<S, Vertex> BothV()
        {
            return new GraphTraversal<S, Vertex>(_gremlin.BothV());
        }

        public IGraphTraversal<S, E2> Branch<E2>(IFunction function)
        {
            return new GraphTraversal<S, E2>(_gremlin.Branch<E2>(function));
        }

        public IGraphTraversal<S, E2> Branch<E2>(ITraversal branchTraversal)
        {
            return new GraphTraversal<S, E2>(_gremlin.Branch<E2>(branchTraversal));
        }

        public IGraphTraversal<S, E> By(string key, IComparator comparator)
        {
            return new GraphTraversal<S, E>(_gremlin.By(key, comparator));
        }

        public IGraphTraversal<S, E> By()
        {
            return new GraphTraversal<S, E>(_gremlin.By());
        }

        public IGraphTraversal<S, E> By(IComparator comparator)
        {
            return new GraphTraversal<S, E>(_gremlin.By(comparator));
        }

        public IGraphTraversal<S, E> By(IFunction function)
        {
            return new GraphTraversal<S, E>(_gremlin.By(function));
        }

        public IGraphTraversal<S, E> By(IFunction function, IComparator comparator)
        {
            return new GraphTraversal<S, E>(_gremlin.By(function, comparator));
        }

        public IGraphTraversal<S, E> By(Order order)
        {
            return new GraphTraversal<S, E>(_gremlin.By(order));
        }

        public IGraphTraversal<S, E> By(string key)
        {
            return new GraphTraversal<S, E>(_gremlin.By(key));
        }

        public IGraphTraversal<S, E> By(T token)
        {
            return new GraphTraversal<S, E>(_gremlin.By(token));
        }

        public IGraphTraversal<S, E> By(ITraversal traversal)
        {
            return new GraphTraversal<S, E>(_gremlin.By(traversal));
        }

        public IGraphTraversal<S, E> By(ITraversal traversal, IComparator comparator)
        {
            return new GraphTraversal<S, E>(_gremlin.By(traversal, comparator));
        }

        public IGraphTraversal<S, E2> Cap<E2>(string sideEffectKey, params string[] sideEffectKeys)
        {
            return new GraphTraversal<S, E2>(_gremlin.Cap<E2>(sideEffectKey, sideEffectKeys));
        }

        public IGraphTraversal<S, E2> Choose<E2>(IPredicate choosePredicate, ITraversal trueChoice, ITraversal falseChoice)
        {
            return new GraphTraversal<S, E2>(_gremlin.Choose<E2>(choosePredicate, trueChoice, falseChoice));
        }

        public IGraphTraversal<S, E2> Choose<E2>(IPredicate choosePredicate, ITraversal trueChoice)
        {
            return new GraphTraversal<S, E2>(_gremlin.Choose<E2>(choosePredicate, trueChoice));
        }

        public IGraphTraversal<S, E2> Choose<E2>(ITraversal choiceTraversal)
        {
            return new GraphTraversal<S, E2>(_gremlin.Choose<E2>(choiceTraversal));
        }

        public IGraphTraversal<S, E2> Choose<E2>(ITraversal traversalPredicate, ITraversal trueChoice, ITraversal falseChoice)
        {
            return new GraphTraversal<S, E2>(_gremlin.Choose<E2>(traversalPredicate, trueChoice, falseChoice));
        }

        public IGraphTraversal<S, E2> Choose<E2>(IFunction choiceFunction)
        {
            return new GraphTraversal<S, E2>(_gremlin.Choose<E2>(choiceFunction));
        }

        public IGraphTraversal<S, E2> Choose<E2>(ITraversal traversalPredicate, ITraversal trueChoice)
        {
            return new GraphTraversal<S, E2>(_gremlin.Choose<E2>(traversalPredicate, trueChoice));
        }

        public IGraphTraversal<S, E> Clone()
        {
            return new GraphTraversal<S, E>(_gremlin.Clone());
        }

        public IGraphTraversal<S, E2> Coalesce<E2>(params ITraversal[] coalesceTraversals)
        {
            return new GraphTraversal<S, E2>(_gremlin.Coalesce<E2>(coalesceTraversals));
        }

        public IGraphTraversal<S, E> Coin(double probability)
        {
            return new GraphTraversal<S, E>(_gremlin.Coin(probability));
        }

        public IGraphTraversal<S, E> ConnectedComponent()
        {
            return new GraphTraversal<S, E>(_gremlin.ConnectedComponent());
        }

        public IGraphTraversal<S, E2> Constant<E2>(E2 e)
        {
            return new GraphTraversal<S, E2>(_gremlin.Constant(e));
        }

        public IGraphTraversal<S, long> Count()
        {
            return new GraphTraversal<S, long>(_gremlin.Count());
        }

        public IGraphTraversal<S, long> Count(Scope scope)
        {
            return new GraphTraversal<S, long>(_gremlin.Count(scope));
        }

        public IGraphTraversal<S, E> CyclicPath()
        {
            return new GraphTraversal<S, E>(_gremlin.CyclicPath());
        }

        public IGraphTraversal<S, E> Dedup(Scope scope, params string[] dedupLabels)
        {
            return new GraphTraversal<S, E>(_gremlin.Dedup(scope, dedupLabels));
        }

        public IGraphTraversal<S, E> Dedup(params string[] dedupLabels)
        {
            return new GraphTraversal<S, E>(_gremlin.Dedup(dedupLabels));
        }

        public IGraphTraversal<S, E> Drop()
        {
            return new GraphTraversal<S, E>(_gremlin.Drop());
        }

        public IGraphTraversal<S, IDictionary<object, E2>> ElementMap<E2>(params string[] propertyKeys)
        {
            return new GraphTraversal<S, IDictionary<object, E2>>(_gremlin.ElementMap<E2>(propertyKeys));
        }

        public IGraphTraversal<S, E> Emit()
        {
            return new GraphTraversal<S, E>(_gremlin.Emit());
        }

        public IGraphTraversal<S, E> Emit(IPredicate emitPredicate)
        {
            return new GraphTraversal<S, E>(_gremlin.Emit(emitPredicate));
        }

        public IGraphTraversal<S, E> Emit(ITraversal emitTraversal)
        {
            return new GraphTraversal<S, E>(_gremlin.Emit(emitTraversal));
        }

        public IGraphTraversal<S, E> Filter(ITraversal filterTraversal)
        {
            return new GraphTraversal<S, E>(_gremlin.Filter(filterTraversal));
        }

        public IGraphTraversal<S, E> Filter(IPredicate predicate)
        {
            return new GraphTraversal<S, E>(_gremlin.Filter(predicate));
        }

        public IGraphTraversal<S, E2> FlatMap<E2>(IFunction function)
        {
            return new GraphTraversal<S, E2>(_gremlin.FlatMap<E2>(function));
        }

        public IGraphTraversal<S, E2> FlatMap<E2>(ITraversal flatMapTraversal)
        {
            return new GraphTraversal<S, E2>(_gremlin.FlatMap<E2>(flatMapTraversal));
        }

        public IGraphTraversal<S, IList<E>> Fold()
        {
            return new GraphTraversal<S, IList<E>>(_gremlin.Fold());
        }

        public IGraphTraversal<S, E2> Fold<E2>(E2 seed, IBiFunction foldFunction)
        {
            return new GraphTraversal<S, E2>(_gremlin.Fold(seed, foldFunction));
        }

        public IGraphTraversal<S, E> From(string fromStepLabel)
        {
            return new GraphTraversal<S, E>(_gremlin.From(fromStepLabel));
        }

        public IGraphTraversal<S, E> From(ITraversal fromVertex)
        {
            return new GraphTraversal<S, E>(_gremlin.From(fromVertex));
        }

        public IGraphTraversal<S, E> From(Vertex fromVertex)
        {
            return new GraphTraversal<S, E>(_gremlin.From(fromVertex));
        }

        public IGraphTraversal<S, IDictionary<K, V>> Group<K, V>()
        {
            return new GraphTraversal<S, IDictionary<K, V>>(_gremlin.Group<K, V>());
        }

        public IGraphTraversal<S, E> Group(string sideEffectKey)
        {
            return new GraphTraversal<S, E>(_gremlin.Group(sideEffectKey));
        }

        public IGraphTraversal<S, IDictionary<K, long>> GroupCount<K>()
        {
            return new GraphTraversal<S, IDictionary<K, long>>(_gremlin.GroupCount<K>());
        }

        public IGraphTraversal<S, E> GroupCount(string sideEffectKey)
        {
            return new GraphTraversal<S, E>(_gremlin.GroupCount(sideEffectKey));
        }

        public IGraphTraversal<S, E> Has(T accessor, object value)
        {
            return new GraphTraversal<S, E>(_gremlin.Has(accessor, value));
        }

        public IGraphTraversal<S, E> Has(T accessor, ITraversal propertyTraversal)
        {
            return new GraphTraversal<S, E>(_gremlin.Has(accessor, propertyTraversal));
        }

        public IGraphTraversal<S, E> Has(T accessor, IPredicate predicate)
        {
            return new GraphTraversal<S, E>(_gremlin.Has(accessor, predicate));
        }

        public IGraphTraversal<S, E> Has(string propertyKey, ITraversal propertyTraversal)
        {
            return new GraphTraversal<S, E>(_gremlin.Has(propertyKey, propertyTraversal));
        }

        public IGraphTraversal<S, E> Has(string propertyKey)
        {
            return new GraphTraversal<S, E>(_gremlin.Has(propertyKey));
        }

        public IGraphTraversal<S, E> Has(string label, string propertyKey, object value)
        {
            return new GraphTraversal<S, E>(_gremlin.Has(label, propertyKey, value));
        }

        public IGraphTraversal<S, E> Has(string propertyKey, IPredicate predicate)
        {
            return new GraphTraversal<S, E>(_gremlin.Has(propertyKey, predicate));
        }

        public IGraphTraversal<S, E> Has(string propertyKey, object value)
        {
            return new GraphTraversal<S, E>(_gremlin.Has(propertyKey, value));
        }

        public IGraphTraversal<S, E> Has(string label, string propertyKey, IPredicate predicate)
        {
            return new GraphTraversal<S, E>(_gremlin.Has(label, propertyKey, predicate));
        }

        public IGraphTraversal<S, E> HasId(object id, params object[] otherIds)
        {
            return new GraphTraversal<S, E>(_gremlin.HasId(id, otherIds));
        }

        public IGraphTraversal<S, E> HasId(IPredicate predicate)
        {
            return new GraphTraversal<S, E>(_gremlin.HasId(predicate));
        }

        public IGraphTraversal<S, E> HasKey(IPredicate predicate)
        {
            return new GraphTraversal<S, E>(_gremlin.HasKey(predicate as P));
        }

        public IGraphTraversal<S, E> HasKey(string label, params string[] otherLabels)
        {
            return new GraphTraversal<S, E>(_gremlin.HasKey(label, otherLabels));
        }

        public IGraphTraversal<S, E> HasLabel(IPredicate predicate)
        {
            return new GraphTraversal<S, E>(_gremlin.HasLabel(predicate as P));
        }

        public IGraphTraversal<S, E> HasLabel(string label, params string[] otherLabels)
        {
            return new GraphTraversal<S, E>(_gremlin.HasLabel(label, otherLabels));
        }

        public IGraphTraversal<S, E> HasNot(string propertyKey)
        {
            return new GraphTraversal<S, E>(_gremlin.HasNot(propertyKey));
        }

        public IGraphTraversal<S, E> HasValue(IPredicate predicate)
        {
            return new GraphTraversal<S, E>(_gremlin.HasValue(predicate));
        }

        public IGraphTraversal<S, E> HasValue(object value, params object[] otherValues)
        {
            return new GraphTraversal<S, E>(_gremlin.HasValue(value, otherValues));
        }

        public IGraphTraversal<S, object> Id()
        {
            return new GraphTraversal<S, object>(_gremlin.Id());
        }

        public IGraphTraversal<S, E> Identity()
        {
            return new GraphTraversal<S, E>(_gremlin.Identity());
        }

        public IGraphTraversal<S, Vertex> In(params string[] edgeLabels)
        {
            return new GraphTraversal<S, Vertex>(_gremlin.In(edgeLabels));
        }

        public IGraphTraversal<S, E2> Index<E2>()
        {
            return new GraphTraversal<S, E2>(_gremlin.Index<E2>());
        }

        public IGraphTraversal<S, Edge> InE(params string[] edgeLabels)
        {
            return new GraphTraversal<S, Edge>(_gremlin.InE(edgeLabels));
        }

        public IGraphTraversal<S, E> Inject(params E[] injections)
        {
            return new GraphTraversal<S, E>(_gremlin.Inject(injections));
        }

        public IGraphTraversal<S, Vertex> InV()
        {
            return new GraphTraversal<S, Vertex>(_gremlin.InV());
        }

        public IGraphTraversal<S, E> Is(object value)
        {
            return new GraphTraversal<S, E>(_gremlin.Is(value));
        }

        public IGraphTraversal<S, E> Is(IPredicate predicate)
        {
            return new GraphTraversal<S, E>(_gremlin.Is(predicate));
        }

        public IGraphTraversal<S, string> Key()
        {
            return new GraphTraversal<S, string>(_gremlin.Key());
        }

        public IGraphTraversal<S, string> Label()
        {
            return new GraphTraversal<S, string>(_gremlin.Label());
        }

        public IGraphTraversal<S, E2> Limit<E2>(Scope scope, long limit)
        {
            return new GraphTraversal<S, E2>(_gremlin.Limit<E2>(scope, limit));
        }

        public IGraphTraversal<S, E2> Limit<E2>(long limit)
        {
            return new GraphTraversal<S, E2>(_gremlin.Limit<E2>(limit));
        }

        public IGraphTraversal<S, E2> Local<E2>(ITraversal localTraversal)
        {
            return new GraphTraversal<S, E2>(_gremlin.Local<E2>(localTraversal));
        }

        public IGraphTraversal<S, int> Loops()
        {
            return new GraphTraversal<S, int>(_gremlin.Loops());
        }

        public IGraphTraversal<S, int> Loops(string loopName)
        {
            return new GraphTraversal<S, int>(_gremlin.Loops(loopName));
        }

        public IGraphTraversal<S, E2> Map<E2>(IFunction function)
        {
            return new GraphTraversal<S, E2>(_gremlin.Map<E2>(function));
        }

        public IGraphTraversal<S, E2> Map<E2>(ITraversal mapTraversal)
        {
            return new GraphTraversal<S, E2>(_gremlin.Map<E2>(mapTraversal));
        }

        public IGraphTraversal<S, IDictionary<string, E2>> Match<E2>(params ITraversal[] matchTraversals)
        {
            return new GraphTraversal<S, IDictionary<string, E2>>(_gremlin.Match<E2>(matchTraversals));
        }

        public IGraphTraversal<S, double> Math(string expression)
        {
            return new GraphTraversal<S, double>(_gremlin.Math(expression));
        }

        public IGraphTraversal<S, E2> Max<E2>()
        {
            return new GraphTraversal<S, E2>(_gremlin.Max<E2>());
        }

        public IGraphTraversal<S, E2> Max<E2>(Scope scope)
        {
            return new GraphTraversal<S, E2>(_gremlin.Max<E2>(scope));
        }

        public IGraphTraversal<S, E2> Mean<E2>()
        {
            return new GraphTraversal<S, E2>(_gremlin.Mean<E2>());
        }

        public IGraphTraversal<S, E2> Mean<E2>(Scope scope)
        {
            return new GraphTraversal<S, E2>(_gremlin.Mean<E2>(scope));
        }

        public IGraphTraversal<S, E2> Min<E2>()
        {
            return new GraphTraversal<S, E2>(_gremlin.Min<E2>());
        }

        public IGraphTraversal<S, E2> Min<E2>(Scope scope)
        {
            return new GraphTraversal<S, E2>(_gremlin.Min<E2>(scope));
        }

        public IGraphTraversal<S, E> Not(ITraversal notTraversal)
        {
            return new GraphTraversal<S, E>(_gremlin.Not(notTraversal));
        }

        public IGraphTraversal<S, E> Option(object pickToken, ITraversal traversalOption)
        {
            return new GraphTraversal<S, E>(_gremlin.Option(pickToken, traversalOption));
        }

        public IGraphTraversal<S, E> Option(ITraversal traversalOption)
        {
            return new GraphTraversal<S, E>(_gremlin.Option(traversalOption));
        }

        public IGraphTraversal<S, E2> Optional<E2>(ITraversal optionalTraversal)
        {
            return new GraphTraversal<S, E2>(_gremlin.Optional<E2>(optionalTraversal));
        }

        public IGraphTraversal<S, E> Or(params ITraversal[] orTraversals)
        {
            return new GraphTraversal<S, E>(_gremlin.Or(orTraversals));
        }

        public IGraphTraversal<S, E> Order()
        {
            return new GraphTraversal<S, E>(_gremlin.Order());
        }

        public IGraphTraversal<S, E> Order(Scope scope)
        {
            return new GraphTraversal<S, E>(_gremlin.Order(scope));
        }

        public IGraphTraversal<S, Vertex> OtherV()
        {
            return new GraphTraversal<S, Vertex>(_gremlin.OtherV());
        }

        public IGraphTraversal<S, Vertex> Out(params string[] edgeLabels)
        {
            return new GraphTraversal<S, Vertex>(_gremlin.Out(edgeLabels));
        }

        public IGraphTraversal<S, Edge> OutE(params string[] edgeLabels)
        {
            return new GraphTraversal<S, Edge>(_gremlin.OutE(edgeLabels));
        }

        public IGraphTraversal<S, Vertex> OutV()
        {
            return new GraphTraversal<S, Vertex>(_gremlin.OutV());
        }

        public IGraphTraversal<S, E> PageRank()
        {
            return new GraphTraversal<S, E>(_gremlin.PageRank());
        }

        public IGraphTraversal<S, E> PageRank(double alpha)
        {
            return new GraphTraversal<S, E>(_gremlin.PageRank(alpha));
        }

        public IGraphTraversal<S, Path> Path()
        {
            return new GraphTraversal<S, Path>(_gremlin.Path());
        }

        public IGraphTraversal<S, E> PeerPressure()
        {
            return new GraphTraversal<S, E>(_gremlin.PeerPressure());
        }

        public IGraphTraversal<S, E> Profile(string sideEffectKey)
        {
            return new GraphTraversal<S, E>(_gremlin.Profile(sideEffectKey));
        }

        public IGraphTraversal<S, E2> Profile<E2>()
        {
            return new GraphTraversal<S, E2>(_gremlin.Profile<E2>());
        }

        public IGraphTraversal<S, E> Program(object vertexProgram)
        {
            return new GraphTraversal<S, E>(_gremlin.Program(vertexProgram));
        }

        public IGraphTraversal<S, IDictionary<string, E2>> Project<E2>(string projectKey, params string[] otherProjectKeys)
        {
            return new GraphTraversal<S, IDictionary<string, E2>>(_gremlin.Project<E2>(projectKey, otherProjectKeys));
        }

        public IGraphTraversal<S, E2> Properties<E2>(params string[] propertyKeys)
        {
            return new GraphTraversal<S, E2>(_gremlin.Properties<E2>(propertyKeys));
        }

        public IGraphTraversal<S, E> Property(Cardinality cardinality, object key, object value, params object[] keyValues)
        {
            return new GraphTraversal<S, E>(_gremlin.Property(cardinality, key, value, keyValues));
        }

        public IGraphTraversal<S, E> Property(object key, object value, params object[] keyValues)
        {
            return new GraphTraversal<S, E>(_gremlin.Property(key, value, keyValues));
        }

        public IGraphTraversal<S, IDictionary<string, E2>> PropertyMap<E2>(params string[] propertyKeys)
        {
            return new GraphTraversal<S, IDictionary<string, E2>>(_gremlin.PropertyMap<E2>(propertyKeys));
        }

        public IGraphTraversal<S, E2> Range<E2>(Scope scope, long low, long high)
        {
            return new GraphTraversal<S, E2>(_gremlin.Range<E2>(scope, low, high));
        }

        public IGraphTraversal<S, E2> Range<E2>(long low, long high)
        {
            return new GraphTraversal<S, E2>(_gremlin.Range<E2>(low, high));
        }

        public IGraphTraversal<S, E> Read()
        {
            return new GraphTraversal<S, E>(_gremlin.Read());
        }

        public IGraphTraversal<S, E> Repeat(string loopName, ITraversal repeatTraversal)
        {
            return new GraphTraversal<S, E>(_gremlin.Repeat(loopName, repeatTraversal));
        }

        public IGraphTraversal<S, E> Repeat(ITraversal repeatTraversal)
        {
            return new GraphTraversal<S, E>(_gremlin.Repeat(repeatTraversal));
        }

        public IGraphTraversal<S, E2> Sack<E2>()
        {
            return new GraphTraversal<S, E2>(_gremlin.Sack<E2>());
        }

        public IGraphTraversal<S, E> Sack(IBiFunction sackOperator)
        {
            return new GraphTraversal<S, E>(_gremlin.Sack(sackOperator));
        }

        public IGraphTraversal<S, E> Sample(int amountToSample)
        {
            return new GraphTraversal<S, E>(_gremlin.Sample(amountToSample));
        }

        public IGraphTraversal<S, E> Sample(Scope scope, int amountToSample)
        {
            return new GraphTraversal<S, E>(_gremlin.Sample(scope, amountToSample));
        }

        public IGraphTraversal<S, ICollection<E2>> Select<E2>(Column column)
        {
            return new GraphTraversal<S, ICollection<E2>>(_gremlin.Select<E2>(column));
        }

        public IGraphTraversal<S, E2> Select<E2>(Pop pop, string selectKey)
        {
            return new GraphTraversal<S, E2>(_gremlin.Select<E2>(pop, selectKey));
        }

        public IGraphTraversal<S, IDictionary<string, E2>> Select<E2>(Pop pop, string selectKey1, string selectKey2, params string[] otherSelectKeys)
        {
            return new GraphTraversal<S, IDictionary<string, E2>>(_gremlin.Select<E2>(pop, selectKey1, selectKey2, otherSelectKeys));
        }

        public IGraphTraversal<S, E2> Select<E2>(Pop pop, ITraversal keyTraversal)
        {
            return new GraphTraversal<S, E2>(_gremlin.Select<E2>(pop, keyTraversal));
        }

        public IGraphTraversal<S, E2> Select<E2>(string selectKey)
        {
            return new GraphTraversal<S, E2>(_gremlin.Select<E2>(selectKey));
        }

        public IGraphTraversal<S, IDictionary<string, E2>> Select<E2>(string selectKey1, string selectKey2, params string[] otherSelectKeys)
        {
            return new GraphTraversal<S, IDictionary<string, E2>>(_gremlin.Select<E2>(selectKey1, selectKey2, otherSelectKeys));
        }

        public IGraphTraversal<S, E2> Select<E2>(ITraversal keyTraversal)
        {
            return new GraphTraversal<S, E2>(_gremlin.Select<E2>(keyTraversal));
        }

        public IGraphTraversal<S, Path> ShortestPath()
        {
            return new GraphTraversal<S, Path>(_gremlin.ShortestPath());
        }

        public IGraphTraversal<S, E> SideEffect(IConsumer consumer)
        {
            return new GraphTraversal<S, E>(_gremlin.SideEffect(consumer));
        }

        public IGraphTraversal<S, E> SideEffect(ITraversal sideEffectTraversal)
        {
            return new GraphTraversal<S, E>(_gremlin.SideEffect(sideEffectTraversal));
        }

        public IGraphTraversal<S, E> SimplePath()
        {
            return new GraphTraversal<S, E>(_gremlin.SimplePath());
        }

        public IGraphTraversal<S, E2> Skip<E2>(Scope scope, long skip)
        {
            return new GraphTraversal<S, E2>(_gremlin.Skip<E2>(scope, skip));
        }

        public IGraphTraversal<S, E2> Skip<E2>(long skip)
        {
            return new GraphTraversal<S, E2>(_gremlin.Skip<E2>(skip));
        }

        public IGraphTraversal<S, E> Store(string sideEffectKey)
        {
            return new GraphTraversal<S, E>(_gremlin.Store(sideEffectKey));
        }

        public IGraphTraversal<S, Edge> Subgraph(string sideEffectKey)
        {
            return new GraphTraversal<S, Edge>(_gremlin.Subgraph(sideEffectKey));
        }

        public IGraphTraversal<S, E2> Sum<E2>()
        {
            return new GraphTraversal<S, E2>(_gremlin.Sum<E2>());
        }

        public IGraphTraversal<S, E2> Sum<E2>(Scope scope)
        {
            return new GraphTraversal<S, E2>(_gremlin.Sum<E2>(scope));
        }

        public IGraphTraversal<S, E2> Tail<E2>()
        {
            return new GraphTraversal<S, E2>(_gremlin.Tail<E2>());
        }

        public IGraphTraversal<S, E2> Tail<E2>(Scope scope)
        {
            return new GraphTraversal<S, E2>(_gremlin.Tail<E2>(scope));
        }

        public IGraphTraversal<S, E2> Tail<E2>(Scope scope, long limit)
        {
            return new GraphTraversal<S, E2>(_gremlin.Tail<E2>(scope, limit));
        }

        public IGraphTraversal<S, E2> Tail<E2>(long limit)
        {
            return new GraphTraversal<S, E2>(_gremlin.Tail<E2>(limit));
        }

        public IGraphTraversal<S, E> TimeLimit(long timeLimit)
        {
            return new GraphTraversal<S, E>(_gremlin.TimeLimit(timeLimit));
        }

        public IGraphTraversal<S, E> Times(int maxLoops)
        {
            return new GraphTraversal<S, E>(_gremlin.Times(maxLoops));
        }

        public IGraphTraversal<S, Vertex> To(Direction direction, params string[] edgeLabels)
        {
            return new GraphTraversal<S, Vertex>(_gremlin.To(direction, edgeLabels));
        }

        public IGraphTraversal<S, E> To(string toStepLabel)
        {
            return new GraphTraversal<S, E>(_gremlin.To(toStepLabel));
        }

        public IGraphTraversal<S, E> To(ITraversal toVertex)
        {
            return new GraphTraversal<S, E>(_gremlin.To(toVertex));
        }

        public IGraphTraversal<S, E> To(Vertex toVertex)
        {
            return new GraphTraversal<S, E>(_gremlin.To(toVertex));
        }

        public IGraphTraversal<S, Edge> ToE(Direction direction, params string[] edgeLabels)
        {
            return new GraphTraversal<S, Edge>(_gremlin.ToE(direction, edgeLabels));
        }

        public IGraphTraversal<S, Vertex> ToV(Direction direction)
        {
            return new GraphTraversal<S, Vertex>(_gremlin.ToV(direction));
        }

        public IGraphTraversal<S, E2> Tree<E2>()
        {
            return new GraphTraversal<S, E2>(_gremlin.Tree<E2>());
        }

        public IGraphTraversal<S, E> Tree(string sideEffectKey)
        {
            return new GraphTraversal<S, E>(_gremlin.Tree(sideEffectKey));
        }

        public IGraphTraversal<S, E2> Unfold<E2>()
        {
            return new GraphTraversal<S, E2>(_gremlin.Unfold<E2>());
        }

        public IGraphTraversal<S, E2> Union<E2>(params ITraversal[] unionTraversals)
        {
            return new GraphTraversal<S, E2>(_gremlin.Union<E2>(unionTraversals));
        }

        public IGraphTraversal<S, E> Until(ITraversal untilTraversal)
        {
            return new GraphTraversal<S, E>(_gremlin.Until(untilTraversal));
        }

        public IGraphTraversal<S, E> Until(IPredicate untilPredicate)
        {
            return new GraphTraversal<S, E>(_gremlin.Until(untilPredicate));
        }

        public IGraphTraversal<S, Vertex> V(params object[] vertexIdsOrElements)
        {
            return new GraphTraversal<S, Vertex>(_gremlin.V(vertexIdsOrElements));
        }

        public IGraphTraversal<S, E2> Value<E2>()
        {
            return new GraphTraversal<S, E2>(_gremlin.Value<E2>());
        }

        public IGraphTraversal<S, IDictionary<TKey, TValue>> ValueMap<TKey, TValue>(params string[] propertyKeys)
        {
            return new GraphTraversal<S, IDictionary<TKey, TValue>>(_gremlin.ValueMap<TKey, TValue>(propertyKeys));
        }

        public IGraphTraversal<S, IDictionary<TKey, TValue>> ValueMap<TKey, TValue>(bool includeTokens, params string[] propertyKeys)
        {
            return new GraphTraversal<S, IDictionary<TKey, TValue>>(_gremlin.ValueMap<TKey, TValue>(includeTokens, propertyKeys));
        }

        public IGraphTraversal<S, E2> Values<E2>(params string[] propertyKeys)
        {
            return new GraphTraversal<S, E2>(_gremlin.Values<E2>(propertyKeys));
        }

        public IGraphTraversal<S, E> Where(IPredicate predicate)
        {
            return new GraphTraversal<S, E>(_gremlin.Where(predicate as P));
        }

        public IGraphTraversal<S, E> Where(string startKey, IPredicate predicate)
        {
            return new GraphTraversal<S, E>(_gremlin.Where(startKey, predicate as P));
        }

        public IGraphTraversal<S, E> Where(ITraversal whereTraversal)
        {
            return new GraphTraversal<S, E>(_gremlin.Where(whereTraversal));
        }

        public IGraphTraversal<S, E> With(string key)
        {
            return new GraphTraversal<S, E>(_gremlin.With(key));
        }

        public IGraphTraversal<S, E> With(string key, object value)
        {
            return new GraphTraversal<S, E>(_gremlin.With(key, value));
        }

        public IGraphTraversal<S, E> Write()
        {
            return new GraphTraversal<S, E>(_gremlin.Write());
        }
    }
}
