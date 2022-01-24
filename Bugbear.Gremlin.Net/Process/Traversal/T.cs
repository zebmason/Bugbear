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

// THIS IS A GENERATED FILE - DO NOT MODIFY THIS FILE DIRECTLY - see pom.xml
using System;
using System.Collections.Generic;

namespace Gremlin.Net.Process.Traversal
{
#pragma warning disable 1591

    public class T : EnumWrapper, IFunction
    {
        private T(string enumValue)
            : base("T", enumValue)
        {
        }

        public static T Id => new T("id");

        public static T Key => new T("key");

        public static T Label => new T("label");

        public static T Value => new T("value");

        private static readonly IDictionary<string, T> Properties = new Dictionary<string, T>
        {
            { "id", Id },
            { "key", Key },
            { "label", Label },
            { "value", Value },
        };

        /// <summary>
        /// Gets the T enumeration by value.
        /// </summary>
        public static T GetByValue(string value)
        {
            if (!Properties.TryGetValue(value, out var property))
            {
                throw new ArgumentException($"No matching T for value '{value}'");
            }
            return property;
        }
    }


#pragma warning restore 1591
}