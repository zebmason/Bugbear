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

namespace Bugbear.Graph.Wrapper
{
    public class GraphTraversalSource : IGraphTraversalSource
    {
        private readonly IGraphDB _graph;

        public GraphTraversalSource(IGraphDB graph)
        {
            _graph = graph;
        }

        public IGraphTraversal<Edge, Edge> AddE(ITraversal edgeLabelTraversal)
        {
            throw new System.NotImplementedException();
        }

        public IGraphTraversal<Edge, Edge> AddE(string label)
        {
            throw new System.NotImplementedException();
        }

        public IGraphTraversal<Vertex, Vertex> AddV(string label)
        {
            throw new System.NotImplementedException();
        }

        public IGraphTraversal<Vertex, Vertex> AddV(ITraversal vertexLabelTraversal)
        {
            throw new System.NotImplementedException();
        }

        public IGraphTraversal<Vertex, Vertex> AddV()
        {
            throw new System.NotImplementedException();
        }

        public IGraphTraversal<Edge, Edge> E(params object[] edgesIds)
        {
            throw new System.NotImplementedException();
        }

        public IGraphTraversal<S, S> Inject<S>(params S[] starts)
        {
            throw new System.NotImplementedException();
        }

        public IGraphTraversal<S, S> Io<S>(string file)
        {
            throw new System.NotImplementedException();
        }

        public IGraphTraversal<Vertex, Vertex> V(params object[] vertexIds)
        {
            return new GraphTraversal<Vertex, Vertex>(_graph, _graph.Vertices(vertexIds));
        }
    }
}
