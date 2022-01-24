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

using System;
using System.Collections.Generic;
using Gremlin.Net.Driver.Messages;

namespace Gremlin.Net.Driver.Exceptions
{
    /// <summary>
    ///     The exception that is thrown when a response is received from Gremlin Server that indicates that an error occurred.
    /// </summary>
    public class ResponseException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ResponseException" /> class.
        /// </summary>
        /// <param name="statusCode">The status code returned by the server.</param>
        /// <param name="statusAttributes">The status attributes from the gremlin response.</param>
        /// <param name="message">The error message string.</param>
        public ResponseException(ResponseStatusCode statusCode,
                                 IReadOnlyDictionary<string, object> statusAttributes,
                                 string message) : base(message)
        {
            StatusCode = statusCode;
            StatusAttributes = statusAttributes;
        }

        /// <summary>
        ///     Gets the status code returned from the server.
        /// </summary>
        public ResponseStatusCode StatusCode { get; }

        /// <summary>
        ///     Gets the status attributes from the gremlin response
        /// </summary>
        public IReadOnlyDictionary<string, object> StatusAttributes { get; }
    }
}