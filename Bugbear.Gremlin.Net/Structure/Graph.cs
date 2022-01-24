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

using System;
using Gremlin.Net.Process.Traversal;

namespace Gremlin.Net.Structure
{
    /// <summary>
    ///     A <see cref="Graph" /> is a container object for a collection of <see cref="Vertex" />, <see cref="Edge" />,
    ///     <see cref="VertexProperty" />, and <see cref="Property" /> objects.
    /// </summary>
    public class Graph
    {
        /// <summary>
        ///     Generates a reusable <see cref="GraphTraversalSource" /> instance.
        /// </summary>
        /// <returns>A graph traversal source.</returns>
        [Obsolete("As of release 3.3.5, replaced by AnonymousTraversalSource.Traversal() called statically.", false)]
        public GraphTraversalSource Traversal()
        {
            return new GraphTraversalSource();
        }
    }
}