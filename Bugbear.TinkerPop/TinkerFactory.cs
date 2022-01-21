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

using Bugbear.Core.Graph;

namespace Bugbear.TinkerPop
{
    public static class TinkerFactory
    {
        public static void CreateModern(IBuildGraphDB graph)
        {
            var marko = graph.AddVertex(1, "person").Add("name", "marko").Add("age", 29);
            var vadas = graph.AddVertex(2, "person").Add("name", "vadas").Add("age", 27);
            var lop = graph.AddVertex(3, "software").Add("name", "lop").Add("lang", "java");
            var josh = graph.AddVertex(4, "person").Add("name", "josh").Add("age", 32);
            var ripple = graph.AddVertex(5, "software").Add("name", "ripple").Add("lang", "java");
            var peter = graph.AddVertex(6, "person").Add("name", "peter").Add("age", 35);

            marko.AddEdge("knows", vadas, 7).Add("weight", 0.5d);
            marko.AddEdge("knows", josh, 8).Add("weight", 1.0d);
            marko.AddEdge("created", lop, 9).Add("weight", 0.4d);
            josh.AddEdge("created", ripple, 10).Add("weight", 1.0d);
            josh.AddEdge("created", lop, 11).Add("weight", 0.4d);
            peter.AddEdge("created", lop, 12).Add("weight", 0.2d);
        }
    }
}
