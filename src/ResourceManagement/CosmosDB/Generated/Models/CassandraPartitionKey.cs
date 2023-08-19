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
    /// Cosmos DB Cassandra table partition key
    /// </summary>
    public partial class CassandraPartitionKey
    {
        /// <summary>
        /// Initializes a new instance of the CassandraPartitionKey class.
        /// </summary>
        public CassandraPartitionKey()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CassandraPartitionKey class.
        /// </summary>
        /// <param name="name">Name of the Cosmos DB Cassandra table partition
        /// key</param>
        public CassandraPartitionKey(string name = default(string))
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Cosmos DB Cassandra table partition key
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
