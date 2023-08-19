// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ARM usage.
    /// </summary>
    public partial class UsageInner
    {
        /// <summary>
        /// Initializes a new instance of the UsageInner class.
        /// </summary>
        public UsageInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsageInner class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="unit">Usage unit.</param>
        /// <param name="currentValue">Usage current value.</param>
        /// <param name="limit">Usage limit.</param>
        /// <param name="requestedLimit">Usage requested limit.</param>
        public UsageInner(string id = default(string), Name name = default(Name), string type = default(string), string unit = default(string), int? currentValue = default(int?), int? limit = default(int?), int? requestedLimit = default(int?))
        {
            Id = id;
            Name = name;
            Type = type;
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            RequestedLimit = requestedLimit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public Name Name { get; private set; }

        /// <summary>
        /// Gets resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets usage unit.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; private set; }

        /// <summary>
        /// Gets usage current value.
        /// </summary>
        [JsonProperty(PropertyName = "currentValue")]
        public int? CurrentValue { get; private set; }

        /// <summary>
        /// Gets usage limit.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; private set; }

        /// <summary>
        /// Gets usage requested limit.
        /// </summary>
        [JsonProperty(PropertyName = "requestedLimit")]
        public int? RequestedLimit { get; private set; }

    }
}
