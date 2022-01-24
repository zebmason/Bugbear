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
using System.Collections.Generic;
using System.Threading.Tasks;
using Gremlin.Net.Driver.Messages;
using Gremlin.Net.Driver.ResultsAggregation;
using Gremlin.Net.Structure.IO.GraphSON;
using Newtonsoft.Json.Linq;

namespace Gremlin.Net.Driver
{
    internal class ResponseHandlerForSingleRequestMessage<T> : IResponseHandlerForSingleRequestMessage
    {
        public Task<ResultSet<T>> Result => _tcs.Task;

        private readonly TaskCompletionSource<ResultSet<T>> _tcs =
            new TaskCompletionSource<ResultSet<T>>(TaskCreationOptions.RunContinuationsAsynchronously);

        private readonly GraphSONReader _graphSONReader;
        private bool _isAggregatingSideEffects;
        private IAggregator _aggregator;
        private readonly List<T> _result = new List<T>();

        public ResponseHandlerForSingleRequestMessage(GraphSONReader graphSonReader)
        {
            _graphSONReader = graphSonReader;
        }

        public void HandleReceived(ResponseMessage<JToken> received)
        {
            var receivedData = typeof(T) == typeof(JToken)
                ? new[] {received.Result.Data}
                : _graphSONReader.ToObject(received.Result.Data);
            #pragma warning disable 612,618
            foreach (var d in receivedData)
            {
                if (received.Result.Meta.ContainsKey(Tokens.ArgsSideEffectKey))
                {
                    if (_aggregator == null)
                        _aggregator =
                            new AggregatorFactory().GetAggregatorFor(
                                (string) received.Result.Meta[Tokens.ArgsAggregateTo]);
                    _aggregator.Add(d);
                    _isAggregatingSideEffects = true;
                }
                else
                {
                    _result.Add(d);
                }
            }
            #pragma warning disable 612,618
        }

        public void Finalize(Dictionary<string, object> statusAttributes)
        {
            var resultSet =
                new ResultSet<T>(
                    _isAggregatingSideEffects ? new List<T> {(T) _aggregator.GetAggregatedResult()} : _result,
                    statusAttributes);
            _tcs.TrySetResult(resultSet);
        }

        public void HandleFailure(Exception objException)
        {
            _tcs.TrySetException(objException);
        }
    }
}