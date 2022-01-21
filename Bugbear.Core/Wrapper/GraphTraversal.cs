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

namespace Bugbear.Core.Wrapper
{
    public class GraphTraversal<S, E> : IGraphTraversal<S, E>
    {
        private readonly Gremlin.Net.Process.Traversal.GraphTraversal<S, E> _gremlin;

        public GraphTraversal(Gremlin.Net.Process.Traversal.GraphTraversal<S, E> gremlin)
        {
            _gremlin = gremlin;
        }

        public IGraphTraversal<S, E> Has(string propertyKey, object value)
        {
            return new GraphTraversal<S, E>(_gremlin.Has(propertyKey, value));
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

        public IGraphTraversal<S, E2> Values<E2>(params string[] propertyKeys)
        {
            return new GraphTraversal<S, E2>(_gremlin.Values<E2>(propertyKeys));
        }
    }
}
