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

namespace Bugbear.Graph.Wrapper
{
    public class GraphTraversalSource : Gremlin.Net.Process.Traversal.GraphTraversalSource
    {
        private readonly IGraphDB _graph;

        public GraphTraversalSource(IGraphDB graph)
        {
            _graph = graph;
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<Edge, Edge> AddE(Gremlin.Net.Process.Traversal.ITraversal edgeLabelTraversal)
        {
            throw new System.NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<Edge, Edge> AddE(string label)
        {
            throw new System.NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<Vertex, Vertex> AddV(string label)
        {
            throw new System.NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<Vertex, Vertex> AddV(Gremlin.Net.Process.Traversal.ITraversal vertexLabelTraversal)
        {
            throw new System.NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<Vertex, Vertex> AddV()
        {
            throw new System.NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<Edge, Edge> E(params object[] edgesIds)
        {
            throw new System.NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, S> Inject<S>(params S[] starts)
        {
            throw new System.NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<S, S> Io<S>(string file)
        {
            throw new System.NotImplementedException();
        }

        public override Gremlin.Net.Process.Traversal.GraphTraversal<Vertex, Vertex> V(params object[] vertexIds)
        {
            return new GraphTraversal<Vertex, Vertex>(_graph, _graph.Vertices(vertexIds));
        }
    }
}
