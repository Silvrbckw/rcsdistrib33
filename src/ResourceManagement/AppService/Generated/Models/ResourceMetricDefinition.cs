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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Metadata for the metrics.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ResourceMetricDefinition : ProxyOnlyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the ResourceMetricDefinition class.
        /// </summary>
        public ResourceMetricDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceMetricDefinition class.
        /// </summary>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="unit">Unit of the metric.</param>
        /// <param name="primaryAggregationType">Primary aggregation
        /// type.</param>
        /// <param name="metricAvailabilities">List of time grains supported
        /// for the metric together with retention period.</param>
        /// <param name="resourceUri">Resource URI.</param>
        /// <param name="properties">Resource metric definition
        /// properties.</param>
        public ResourceMetricDefinition(string id = default(string), string name = default(string), string type = default(string), string kind = default(string), string unit = default(string), string primaryAggregationType = default(string), IList<ResourceMetricAvailability> metricAvailabilities = default(IList<ResourceMetricAvailability>), string resourceUri = default(string), IDictionary<string, string> properties = default(IDictionary<string, string>))
            : base(id, name, type, kind)
        {
            Unit = unit;
            PrimaryAggregationType = primaryAggregationType;
            MetricAvailabilities = metricAvailabilities;
            ResourceUri = resourceUri;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets unit of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "properties.unit")]
        public string Unit { get; private set; }

        /// <summary>
        /// Gets primary aggregation type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryAggregationType")]
        public string PrimaryAggregationType { get; private set; }

        /// <summary>
        /// Gets list of time grains supported for the metric together with
        /// retention period.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metricAvailabilities")]
        public IList<ResourceMetricAvailability> MetricAvailabilities { get; private set; }

        /// <summary>
        /// Gets resource URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceUri")]
        public string ResourceUri { get; private set; }

        /// <summary>
        /// Gets resource metric definition properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties")]
        public IDictionary<string, string> Properties { get; private set; }

    }
}