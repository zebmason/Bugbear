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
    //
    // Summary:
    //     A Gremlin.Net.Process.Traversal.GraphTraversalSource is the primary DSL of the
    //     Gremlin traversal machine. It provides access to all the configurations and steps
    //     for Turing complete graph computing.
    public interface IGraphTraversalSource
    {
        //
        // Summary:
        //     Spawns a Gremlin.Net.Process.Traversal.GraphTraversal`2 off this graph traversal
        //     source and adds the addE step to that traversal.
        IGraphTraversal<Edge, Edge> AddE(ITraversal edgeLabelTraversal);
        //
        // Summary:
        //     Spawns a Gremlin.Net.Process.Traversal.GraphTraversal`2 off this graph traversal
        //     source and adds the addE step to that traversal.
        IGraphTraversal<Edge, Edge> AddE(string label);
        //
        // Summary:
        //     Spawns a Gremlin.Net.Process.Traversal.GraphTraversal`2 off this graph traversal
        //     source and adds the addV step to that traversal.
        IGraphTraversal<Vertex, Vertex> AddV(string label);
        //
        // Summary:
        //     Spawns a Gremlin.Net.Process.Traversal.GraphTraversal`2 off this graph traversal
        //     source and adds the addV step to that traversal.
        IGraphTraversal<Vertex, Vertex> AddV(ITraversal vertexLabelTraversal);
        //
        // Summary:
        //     Spawns a Gremlin.Net.Process.Traversal.GraphTraversal`2 off this graph traversal
        //     source and adds the addV step to that traversal.
        IGraphTraversal<Vertex, Vertex> AddV();
        //
        // Summary:
        //     Spawns a Gremlin.Net.Process.Traversal.GraphTraversal`2 off this graph traversal
        //     source and adds the E step to that traversal.
        IGraphTraversal<Edge, Edge> E(params object[] edgesIds);
        //
        // Summary:
        //     Spawns a Gremlin.Net.Process.Traversal.GraphTraversal`2 off this graph traversal
        //     source and adds the inject step to that traversal.
        IGraphTraversal<S, S> Inject<S>(params S[] starts);
        //
        // Summary:
        //     Spawns a Gremlin.Net.Process.Traversal.GraphTraversal`2 off this graph traversal
        //     source and adds the io step to that traversal.
        IGraphTraversal<S, S> Io<S>(string file);
        //
        // Summary:
        //     Spawns a Gremlin.Net.Process.Traversal.GraphTraversal`2 off this graph traversal
        //     source and adds the V step to that traversal.
        IGraphTraversal<Vertex, Vertex> V(params object[] vertexIds);
    }
}
