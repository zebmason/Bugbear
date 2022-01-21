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

namespace Bugbear.Core.Graph
{
    public class Builder<U> : IBuilder<U>
    {
        public U ToBuild { get; }
        protected readonly IBuildGraphDB _graph;

        public Builder(U vertex, IBuildGraphDB graph)
        {
            ToBuild = vertex;
            _graph = graph;
        }
    }

    public class VertexBuilder : Builder<Vertex>, IVertexBuilder
    {
        public VertexBuilder(Vertex vertex, IBuildGraphDB graph)
            : base(vertex, graph)
        {
        }

        public IVertexBuilder Add(string label, dynamic value)
        {
            _graph.AddVertexProperty(ToBuild, label, value);
            return this;
        }

        public IEdgeBuilder AddEdge(string label, IVertexBuilder other, object id)
        {
            return _graph.AddEdge(id, ToBuild, label, other.ToBuild);
        }
    }

    public class EdgeBuilder : Builder<Edge>, IEdgeBuilder
    {
        public EdgeBuilder(Edge edge, IBuildGraphDB graph)
            : base(edge, graph)
        {
        }

        public IEdgeBuilder Add(string label, dynamic value)
        {
            _graph.AddEdgeProperty(ToBuild, label, value);
            return this;
        }
    }
}
