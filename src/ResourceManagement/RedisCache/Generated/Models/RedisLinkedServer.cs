// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Redis.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Linked server Id
    /// </summary>
    public partial class RedisLinkedServer
    {
        /// <summary>
        /// Initializes a new instance of the RedisLinkedServer class.
        /// </summary>
        public RedisLinkedServer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RedisLinkedServer class.
        /// </summary>
        /// <param name="id">Linked server Id.</param>
        public RedisLinkedServer(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets linked server Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

    }
}
