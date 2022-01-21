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

namespace Bugbear.Core.Wrapper
{
    public class GraphTraversalSource : IGraphTraversalSource
    {
        private readonly Gremlin.Net.Process.Traversal.GraphTraversalSource _source;

        public GraphTraversalSource(Gremlin.Net.Process.Traversal.GraphTraversalSource source)
        {
            _source = source;
        }

        public IGraphTraversal<Edge, Edge> AddE(ITraversal edgeLabelTraversal)
        {
            return new GraphTraversal<Edge, Edge>(_source.AddE(edgeLabelTraversal));
        }

        public IGraphTraversal<Edge, Edge> AddE(string label)
        {
            return new GraphTraversal<Edge, Edge>(_source.AddE(label));
        }

        public IGraphTraversal<Vertex, Vertex> AddV(string label)
        {
            return new GraphTraversal<Vertex, Vertex>(_source.AddV(label));
        }

        public IGraphTraversal<Vertex, Vertex> AddV(ITraversal vertexLabelTraversal)
        {
            return new GraphTraversal<Vertex, Vertex>(_source.AddV(vertexLabelTraversal));
        }

        public IGraphTraversal<Vertex, Vertex> AddV()
        {
            return new GraphTraversal<Vertex, Vertex>(_source.AddV());
        }

        public IGraphTraversal<Edge, Edge> E(params object[] edgesIds)
        {
            return new GraphTraversal<Edge, Edge>(_source.E(edgesIds));
        }

        public IGraphTraversal<S, S> Inject<S>(params S[] starts)
        {
            return new GraphTraversal<S, S>(_source.Inject(starts));
        }

        public IGraphTraversal<S, S> Io<S>(string file)
        {
            return new GraphTraversal<S, S>(_source.Io<S>(file));
        }

        public IGraphTraversal<Vertex, Vertex> V(params object[] vertexIds)
        {
            return new GraphTraversal<Vertex, Vertex>(_source.V(vertexIds));
        }
    }
}
