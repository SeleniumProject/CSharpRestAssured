﻿// <copyright file="DeserializeAs.cs" company="On Test Automation">
// Copyright 2019 the original author or authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

namespace RestAssured.Response.Deserialization
{
    /// <summary>
    /// Contains the different options for forcing deserialization from a specific format.
    /// </summary>
    public enum DeserializeAs
    {
        /// <summary>
        /// Indicates using the actual response Content-Type header value.
        /// </summary>
        UseResponseContentTypeHeaderValue = 0,

        /// <summary>
        /// Deserialize response as JSON, overriding the response Content-Type header.
        /// </summary>
        Json = 1,

        /// <summary>
        /// Deserialize response as XML, overriding the response Content-Type header.
        /// </summary>
        Xml = 2,
    }
}
