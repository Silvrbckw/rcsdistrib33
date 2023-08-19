// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Hybrid Connection for an App Service app.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RelayServiceConnectionEntityInner : ProxyOnlyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the RelayServiceConnectionEntityInner
        /// class.
        /// </summary>
        public RelayServiceConnectionEntityInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RelayServiceConnectionEntityInner
        /// class.
        /// </summary>
        /// <param name="kind">Kind of resource.</param>
        public RelayServiceConnectionEntityInner(string id = default(string), string name = default(string), string type = default(string), string kind = default(string), string entityName = default(string), string entityConnectionString = default(string), string resourceType = default(string), string resourceConnectionString = default(string), string hostname = default(string), int? port = default(int?), string biztalkUri = default(string))
            : base(id, name, type, kind)
        {
            EntityName = entityName;
            EntityConnectionString = entityConnectionString;
            ResourceType = resourceType;
            ResourceConnectionString = resourceConnectionString;
            Hostname = hostname;
            Port = port;
            BiztalkUri = biztalkUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.entityName")]
        public string EntityName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.entityConnectionString")]
        public string EntityConnectionString { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceType")]
        public string ResourceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceConnectionString")]
        public string ResourceConnectionString { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.port")]
        public int? Port { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.biztalkUri")]
        public string BiztalkUri { get; set; }

    }
}
