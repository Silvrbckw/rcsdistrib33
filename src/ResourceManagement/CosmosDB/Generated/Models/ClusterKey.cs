// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Cosmos DB Cassandra table cluster key
    /// </summary>
    public partial class ClusterKey
    {
        /// <summary>
        /// Initializes a new instance of the ClusterKey class.
        /// </summary>
        public ClusterKey()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterKey class.
        /// </summary>
        /// <param name="name">Name of the Cosmos DB Cassandra table cluster
        /// key</param>
        /// <param name="orderBy">Order of the Cosmos DB Cassandra table
        /// cluster key, only support "Asc" and "Desc"</param>
        public ClusterKey(string name = default(string), string orderBy = default(string))
        {
            Name = name;
            OrderBy = orderBy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Cosmos DB Cassandra table cluster key
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets order of the Cosmos DB Cassandra table cluster key,
        /// only support "Asc" and "Desc"
        /// </summary>
        [JsonProperty(PropertyName = "orderBy")]
        public string OrderBy { get; set; }

    }
}
