﻿#region License

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

using System.Collections.Generic;
using Gremlin.Net.Process.Traversal;

namespace Gremlin.Net.Structure.IO.GraphSON
{
    internal class PSerializer : IGraphSONSerializer
    {
        public Dictionary<string, dynamic> Dictify(dynamic predicate, GraphSONWriter writer)
        {
            P p = predicate;
            var value = p.Other == null
                ? writer.ToDict(p.Value)
                : new List<dynamic> {writer.ToDict(p.Value), writer.ToDict(p.Other)};
            var dict = new Dictionary<string, dynamic>
            {
                {"predicate", p.OperatorName},
                {"value", value}
            };
            return GraphSONUtil.ToTypedValue("P", dict);
        }
    }
}