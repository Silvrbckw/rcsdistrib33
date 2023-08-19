// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A region in which the Azure Cosmos DB database account is deployed.
    /// </summary>
    public partial class Location
    {
        /// <summary>
        /// Initializes a new instance of the Location class.
        /// </summary>
        public Location()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Location class.
        /// </summary>
        /// <param name="id">The unique identifier of the region within the
        /// database account. Example:
        /// &amp;lt;accountName&amp;gt;-&amp;lt;locationName&amp;gt;.</param>
        /// <param name="locationName">The name of the region.</param>
        /// <param name="documentEndpoint">The connection endpoint for the
        /// specific region. Example:
        /// https://&amp;lt;accountName&amp;gt;-&amp;lt;locationName&amp;gt;.documents.azure.com:443/</param>
        /// <param name="failoverPriority">The failover priority of the region.
        /// A failover priority of 0 indicates a write region. The maximum
        /// value for a failover priority = (total number of regions - 1).
        /// Failover priority values must be unique for each of the regions in
        /// which the database account exists.</param>
        /// <param name="isZoneRedundant">Flag to indicate whether or not this
        /// region is an AvailabilityZone region</param>
        public Location(string id = default(string), string locationName = default(string), string documentEndpoint = default(string), string provisioningState = default(string), int? failoverPriority = default(int?), bool? isZoneRedundant = default(bool?))
        {
            Id = id;
            LocationName = locationName;
            DocumentEndpoint = documentEndpoint;
            ProvisioningState = provisioningState;
            FailoverPriority = failoverPriority;
            IsZoneRedundant = isZoneRedundant;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the unique identifier of the region within the database
        /// account. Example:
        /// &amp;amp;lt;accountName&amp;amp;gt;-&amp;amp;lt;locationName&amp;amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the name of the region.
        /// </summary>
        [JsonProperty(PropertyName = "locationName")]
        public string LocationName { get; set; }

        /// <summary>
        /// Gets the connection endpoint for the specific region. Example:
        /// https://&amp;amp;lt;accountName&amp;amp;gt;-&amp;amp;lt;locationName&amp;amp;gt;.documents.azure.com:443/
        /// </summary>
        [JsonProperty(PropertyName = "documentEndpoint")]
        public string DocumentEndpoint { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the failover priority of the region. A failover
        /// priority of 0 indicates a write region. The maximum value for a
        /// failover priority = (total number of regions - 1). Failover
        /// priority values must be unique for each of the regions in which the
        /// database account exists.
        /// </summary>
        [JsonProperty(PropertyName = "failoverPriority")]
        public int? FailoverPriority { get; set; }

        /// <summary>
        /// Gets or sets flag to indicate whether or not this region is an
        /// AvailabilityZone region
        /// </summary>
        [JsonProperty(PropertyName = "isZoneRedundant")]
        public bool? IsZoneRedundant { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FailoverPriority < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "FailoverPriority", 0);
            }
        }
    }
}
