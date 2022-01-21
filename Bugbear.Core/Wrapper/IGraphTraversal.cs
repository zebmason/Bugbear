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
    //
    // Summary:
    //     Graph traversals are the primary way in which graphs are processed.
    public interface IGraphTraversal<S, E>
    {
        //
        // Summary:
        //     Adds the addE step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Edge> AddE(string edgeLabel);
        //
        // Summary:
        //     Adds the addE step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Edge> AddE(ITraversal edgeLabelTraversal);
        //
        // Summary:
        //     Adds the addV step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Vertex> AddV();
        //
        // Summary:
        //     Adds the addV step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Vertex> AddV(string vertexLabel);
        //
        // Summary:
        //     Adds the addV step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Vertex> AddV(ITraversal vertexLabelTraversal);
        //
        // Summary:
        //     Adds the aggregate step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Aggregate(Scope scope, string sideEffectKey);
        //
        // Summary:
        //     Adds the aggregate step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Aggregate(string sideEffectKey);
        //
        // Summary:
        //     Adds the and step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> And(params ITraversal[] andTraversals);
        //
        // Summary:
        //     Adds the as step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> As(string stepLabel, params string[] stepLabels);
        //
        // Summary:
        //     Adds the barrier step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Barrier();
        //
        // Summary:
        //     Adds the barrier step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Barrier(IConsumer barrierConsumer);
        //
        // Summary:
        //     Adds the barrier step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Barrier(int maxBarrierSize);
        //
        // Summary:
        //     Adds the both step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Vertex> Both(params string[] edgeLabels);
        //
        // Summary:
        //     Adds the bothE step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Edge> BothE(params string[] edgeLabels);
        //
        // Summary:
        //     Adds the bothV step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Vertex> BothV();
        //
        // Summary:
        //     Adds the branch step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Branch<E2>(IFunction function);
        //
        // Summary:
        //     Adds the branch step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Branch<E2>(ITraversal branchTraversal);
        //
        // Summary:
        //     Adds the by step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> By(string key, IComparator comparator);
        //
        // Summary:
        //     Adds the by step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> By();
        //
        // Summary:
        //     Adds the by step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> By(IComparator comparator);
        //
        // Summary:
        //     Adds the by step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> By(IFunction function);
        //
        // Summary:
        //     Adds the by step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> By(IFunction function, IComparator comparator);
        //
        // Summary:
        //     Adds the by step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> By(Order order);
        //
        // Summary:
        //     Adds the by step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> By(string key);
        //
        // Summary:
        //     Adds the by step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> By(T token);
        //
        // Summary:
        //     Adds the by step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> By(ITraversal traversal);
        //
        // Summary:
        //     Adds the by step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> By(ITraversal traversal, IComparator comparator);
        //
        // Summary:
        //     Adds the cap step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Cap<E2>(string sideEffectKey, params string[] sideEffectKeys);
        //
        // Summary:
        //     Adds the choose step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Choose<E2>(IPredicate choosePredicate, ITraversal trueChoice, ITraversal falseChoice);
        //
        // Summary:
        //     Adds the choose step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Choose<E2>(IPredicate choosePredicate, ITraversal trueChoice);
        //
        // Summary:
        //     Adds the choose step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Choose<E2>(ITraversal choiceTraversal);
        //
        // Summary:
        //     Adds the choose step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Choose<E2>(ITraversal traversalPredicate, ITraversal trueChoice, ITraversal falseChoice);
        //
        // Summary:
        //     Adds the choose step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Choose<E2>(IFunction choiceFunction);
        //
        // Summary:
        //     Adds the choose step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Choose<E2>(ITraversal traversalPredicate, ITraversal trueChoice);
        //
        // Summary:
        //     Make a copy of a traversal that is reset for iteration.
        IGraphTraversal<S, E> Clone();
        //
        // Summary:
        //     Adds the coalesce step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Coalesce<E2>(params ITraversal[] coalesceTraversals);
        //
        // Summary:
        //     Adds the coin step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Coin(double probability);
        //
        // Summary:
        //     Adds the connectedComponent step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> ConnectedComponent();
        //
        // Summary:
        //     Adds the constant step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Constant<E2>(E2 e);
        //
        // Summary:
        //     Adds the count step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, long> Count();
        //
        // Summary:
        //     Adds the count step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, long> Count(Scope scope);
        //
        // Summary:
        //     Adds the cyclicPath step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> CyclicPath();
        //
        // Summary:
        //     Adds the dedup step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Dedup(Scope scope, params string[] dedupLabels);
        //
        // Summary:
        //     Adds the dedup step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Dedup(params string[] dedupLabels);
        //
        // Summary:
        //     Adds the drop step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Drop();
        //
        // Summary:
        //     Adds the elementMap step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, IDictionary<object, E2>> ElementMap<E2>(params string[] propertyKeys);
        //
        // Summary:
        //     Adds the emit step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Emit();
        //
        // Summary:
        //     Adds the emit step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Emit(IPredicate emitPredicate);
        //
        // Summary:
        //     Adds the emit step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Emit(ITraversal emitTraversal);
        //
        // Summary:
        //     Adds the filter step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Filter(ITraversal filterTraversal);
        //
        // Summary:
        //     Adds the filter step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Filter(IPredicate predicate);
        //
        // Summary:
        //     Adds the flatMap step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> FlatMap<E2>(IFunction function);
        //
        // Summary:
        //     Adds the flatMap step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> FlatMap<E2>(ITraversal flatMapTraversal);
        //
        // Summary:
        //     Adds the fold step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, IList<E>> Fold();
        //
        // Summary:
        //     Adds the fold step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Fold<E2>(E2 seed, IBiFunction foldFunction);
        //
        // Summary:
        //     Adds the from step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> From(string fromStepLabel);
        //
        // Summary:
        //     Adds the from step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> From(ITraversal fromVertex);
        //
        // Summary:
        //     Adds the from step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> From(Vertex fromVertex);
        //
        // Summary:
        //     Adds the group step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, IDictionary<K, V>> Group<K, V>();
        //
        // Summary:
        //     Adds the group step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Group(string sideEffectKey);
        //
        // Summary:
        //     Adds the groupCount step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, IDictionary<K, long>> GroupCount<K>();
        //
        // Summary:
        //     Adds the groupCount step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> GroupCount(string sideEffectKey);
        //
        // Summary:
        //     Adds the has step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Has(T accessor, object value);
        //
        // Summary:
        //     Adds the has step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Has(T accessor, ITraversal propertyTraversal);
        //
        // Summary:
        //     Adds the has step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Has(T accessor, IPredicate predicate);
        //
        // Summary:
        //     Adds the has step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Has(string propertyKey, ITraversal propertyTraversal);
        //
        // Summary:
        //     Adds the has step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Has(string propertyKey);
        //
        // Summary:
        //     Adds the has step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Has(string label, string propertyKey, object value);
        //
        // Summary:
        //     Adds the has step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Has(string propertyKey, IPredicate predicate);
        //
        // Summary:
        //     Adds the has step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Has(string propertyKey, object value);
        //
        // Summary:
        //     Adds the has step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Has(string label, string propertyKey, IPredicate predicate);
        //
        // Summary:
        //     Adds the hasId step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> HasId(object id, params object[] otherIds);
        //
        // Summary:
        //     Adds the hasId step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> HasId(IPredicate predicate);
        //
        // Summary:
        //     Adds the hasKey step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> HasKey(IPredicate predicate);
        //
        // Summary:
        //     Adds the hasKey step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> HasKey(string label, params string[] otherLabels);
        //
        // Summary:
        //     Adds the hasLabel step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> HasLabel(IPredicate predicate);
        //
        // Summary:
        //     Adds the hasLabel step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> HasLabel(string label, params string[] otherLabels);
        //
        // Summary:
        //     Adds the hasNot step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> HasNot(string propertyKey);
        //
        // Summary:
        //     Adds the hasValue step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> HasValue(IPredicate predicate);
        //
        // Summary:
        //     Adds the hasValue step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> HasValue(object value, params object[] otherValues);
        //
        // Summary:
        //     Adds the id step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, object> Id();
        //
        // Summary:
        //     Adds the identity step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Identity();
        //
        // Summary:
        //     Adds the in step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Vertex> In(params string[] edgeLabels);
        //
        // Summary:
        //     Adds the index step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Index<E2>();
        //
        // Summary:
        //     Adds the inE step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Edge> InE(params string[] edgeLabels);
        //
        // Summary:
        //     Adds the inject step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Inject(params E[] injections);
        //
        // Summary:
        //     Adds the inV step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Vertex> InV();
        //
        // Summary:
        //     Adds the is step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Is(object value);
        //
        // Summary:
        //     Adds the is step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Is(IPredicate predicate);
        //
        // Summary:
        //     Adds the key step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, string> Key();
        //
        // Summary:
        //     Adds the label step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, string> Label();
        //
        // Summary:
        //     Adds the limit step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Limit<E2>(Scope scope, long limit);
        //
        // Summary:
        //     Adds the limit step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Limit<E2>(long limit);
        //
        // Summary:
        //     Adds the local step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Local<E2>(ITraversal localTraversal);
        //
        // Summary:
        //     Adds the loops step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, int> Loops();
        //
        // Summary:
        //     Adds the loops step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, int> Loops(string loopName);
        //
        // Summary:
        //     Adds the map step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Map<E2>(IFunction function);
        //
        // Summary:
        //     Adds the map step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Map<E2>(ITraversal mapTraversal);
        //
        // Summary:
        //     Adds the match step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, IDictionary<string, E2>> Match<E2>(params ITraversal[] matchTraversals);
        //
        // Summary:
        //     Adds the math step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, double> Math(string expression);
        //
        // Summary:
        //     Adds the max step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Max<E2>();
        //
        // Summary:
        //     Adds the max step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Max<E2>(Scope scope);
        //
        // Summary:
        //     Adds the mean step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Mean<E2>();
        //
        // Summary:
        //     Adds the mean step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Mean<E2>(Scope scope);
        //
        // Summary:
        //     Adds the min step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Min<E2>();
        //
        // Summary:
        //     Adds the min step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Min<E2>(Scope scope);
        //
        // Summary:
        //     Adds the not step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Not(ITraversal notTraversal);
        //
        // Summary:
        //     Adds the option step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Option(object pickToken, ITraversal traversalOption);
        //
        // Summary:
        //     Adds the option step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Option(ITraversal traversalOption);
        //
        // Summary:
        //     Adds the optional step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Optional<E2>(ITraversal optionalTraversal);
        //
        // Summary:
        //     Adds the or step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Or(params ITraversal[] orTraversals);
        //
        // Summary:
        //     Adds the order step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Order();
        //
        // Summary:
        //     Adds the order step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Order(Scope scope);
        //
        // Summary:
        //     Adds the otherV step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Vertex> OtherV();
        //
        // Summary:
        //     Adds the out step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Vertex> Out(params string[] edgeLabels);
        //
        // Summary:
        //     Adds the outE step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Edge> OutE(params string[] edgeLabels);
        //
        // Summary:
        //     Adds the outV step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Vertex> OutV();
        //
        // Summary:
        //     Adds the pageRank step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> PageRank();
        //
        // Summary:
        //     Adds the pageRank step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> PageRank(double alpha);
        //
        // Summary:
        //     Adds the path step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Path> Path();
        //
        // Summary:
        //     Adds the peerPressure step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> PeerPressure();
        //
        // Summary:
        //     Adds the profile step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Profile(string sideEffectKey);
        //
        // Summary:
        //     Adds the profile step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Profile<E2>();
        //
        // Summary:
        //     Adds the program step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Program(object vertexProgram);
        //
        // Summary:
        //     Adds the project step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, IDictionary<string, E2>> Project<E2>(string projectKey, params string[] otherProjectKeys);
        //
        // Summary:
        //     Adds the properties step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Properties<E2>(params string[] propertyKeys);
        //
        // Summary:
        //     Adds the property step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Property(Cardinality cardinality, object key, object value, params object[] keyValues);
        //
        // Summary:
        //     Adds the property step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Property(object key, object value, params object[] keyValues);
        //
        // Summary:
        //     Adds the propertyMap step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, IDictionary<string, E2>> PropertyMap<E2>(params string[] propertyKeys);
        //
        // Summary:
        //     Adds the range step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Range<E2>(Scope scope, long low, long high);
        //
        // Summary:
        //     Adds the range step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Range<E2>(long low, long high);
        //
        // Summary:
        //     Adds the read step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Read();
        //
        // Summary:
        //     Adds the repeat step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Repeat(string loopName, ITraversal repeatTraversal);
        //
        // Summary:
        //     Adds the repeat step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Repeat(ITraversal repeatTraversal);
        //
        // Summary:
        //     Adds the sack step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Sack<E2>();
        //
        // Summary:
        //     Adds the sack step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Sack(IBiFunction sackOperator);
        //
        // Summary:
        //     Adds the sample step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Sample(int amountToSample);
        //
        // Summary:
        //     Adds the sample step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Sample(Scope scope, int amountToSample);
        //
        // Summary:
        //     Adds the select step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, ICollection<E2>> Select<E2>(Column column);
        //
        // Summary:
        //     Adds the select step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Select<E2>(Pop pop, string selectKey);
        //
        // Summary:
        //     Adds the select step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, IDictionary<string, E2>> Select<E2>(Pop pop, string selectKey1, string selectKey2, params string[] otherSelectKeys);
        //
        // Summary:
        //     Adds the select step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Select<E2>(Pop pop, ITraversal keyTraversal);
        //
        // Summary:
        //     Adds the select step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Select<E2>(string selectKey);
        //
        // Summary:
        //     Adds the select step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, IDictionary<string, E2>> Select<E2>(string selectKey1, string selectKey2, params string[] otherSelectKeys);
        //
        // Summary:
        //     Adds the select step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Select<E2>(ITraversal keyTraversal);
        //
        // Summary:
        //     Adds the shortestPath step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Path> ShortestPath();
        //
        // Summary:
        //     Adds the sideEffect step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> SideEffect(IConsumer consumer);
        //
        // Summary:
        //     Adds the sideEffect step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> SideEffect(ITraversal sideEffectTraversal);
        //
        // Summary:
        //     Adds the simplePath step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> SimplePath();
        //
        // Summary:
        //     Adds the skip step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Skip<E2>(Scope scope, long skip);
        //
        // Summary:
        //     Adds the skip step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Skip<E2>(long skip);
        //
        // Summary:
        //     Adds the store step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Store(string sideEffectKey);
        //
        // Summary:
        //     Adds the subgraph step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Edge> Subgraph(string sideEffectKey);
        //
        // Summary:
        //     Adds the sum step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Sum<E2>();
        //
        // Summary:
        //     Adds the sum step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Sum<E2>(Scope scope);
        //
        // Summary:
        //     Adds the tail step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Tail<E2>();
        //
        // Summary:
        //     Adds the tail step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Tail<E2>(Scope scope);
        //
        // Summary:
        //     Adds the tail step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Tail<E2>(Scope scope, long limit);
        //
        // Summary:
        //     Adds the tail step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Tail<E2>(long limit);
        //
        // Summary:
        //     Adds the timeLimit step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> TimeLimit(long timeLimit);
        //
        // Summary:
        //     Adds the times step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Times(int maxLoops);
        //
        // Summary:
        //     Adds the to step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Vertex> To(Direction direction, params string[] edgeLabels);
        //
        // Summary:
        //     Adds the to step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> To(string toStepLabel);
        //
        // Summary:
        //     Adds the to step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> To(ITraversal toVertex);
        //
        // Summary:
        //     Adds the to step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> To(Vertex toVertex);
        //
        // Summary:
        //     Adds the toE step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Edge> ToE(Direction direction, params string[] edgeLabels);
        //
        // Summary:
        //     Adds the toV step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Vertex> ToV(Direction direction);
        //
        // Summary:
        //     Adds the tree step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Tree<E2>();
        //
        // Summary:
        //     Adds the tree step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Tree(string sideEffectKey);
        //
        // Summary:
        //     Adds the unfold step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Unfold<E2>();
        //
        // Summary:
        //     Adds the union step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Union<E2>(params ITraversal[] unionTraversals);
        //
        // Summary:
        //     Adds the until step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Until(ITraversal untilTraversal);
        //
        // Summary:
        //     Adds the until step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Until(IPredicate untilPredicate);
        //
        // Summary:
        //     Adds the V step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, Vertex> V(params object[] vertexIdsOrElements);
        //
        // Summary:
        //     Adds the value step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Value<E2>();
        //
        // Summary:
        //     Adds the valueMap step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, IDictionary<TKey, TValue>> ValueMap<TKey, TValue>(params string[] propertyKeys);
        //
        // Summary:
        //     Adds the valueMap step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, IDictionary<TKey, TValue>> ValueMap<TKey, TValue>(bool includeTokens, params string[] propertyKeys);
        //
        // Summary:
        //     Adds the values step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E2> Values<E2>(params string[] propertyKeys);
        //
        // Summary:
        //     Adds the where step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Where(IPredicate predicate);
        //
        // Summary:
        //     Adds the where step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Where(string startKey, IPredicate predicate);
        //
        // Summary:
        //     Adds the where step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Where(ITraversal whereTraversal);
        //
        // Summary:
        //     Adds the with step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> With(string key);
        //
        // Summary:
        //     Adds the with step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> With(string key, object value);
        //
        // Summary:
        //     Adds the write step to this Gremlin.Net.Process.Traversal.GraphTraversal`2.
        IGraphTraversal<S, E> Write();
    }
}
