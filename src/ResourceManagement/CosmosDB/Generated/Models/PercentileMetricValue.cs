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
    /// Represents percentile metrics values.
    /// </summary>
    public partial class PercentileMetricValue : MetricValue
    {
        /// <summary>
        /// Initializes a new instance of the PercentileMetricValue class.
        /// </summary>
        public PercentileMetricValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PercentileMetricValue class.
        /// </summary>
        /// <param name="_count">The number of values for the metric.</param>
        /// <param name="average">The average value of the metric.</param>
        /// <param name="maximum">The max value of the metric.</param>
        /// <param name="minimum">The min value of the metric.</param>
        /// <param name="timestamp">The metric timestamp (ISO-8601
        /// format).</param>
        /// <param name="total">The total value of the metric.</param>
        /// <param name="p10">The 10th percentile value for the metric.</param>
        /// <param name="p25">The 25th percentile value for the metric.</param>
        /// <param name="p50">The 50th percentile value for the metric.</param>
        /// <param name="p75">The 75th percentile value for the metric.</param>
        /// <param name="p90">The 90th percentile value for the metric.</param>
        /// <param name="p95">The 95th percentile value for the metric.</param>
        /// <param name="p99">The 99th percentile value for the metric.</param>
        public PercentileMetricValue(double? _count = default(double?), double? average = default(double?), double? maximum = default(double?), double? minimum = default(double?), System.DateTime? timestamp = default(System.DateTime?), double? total = default(double?), double? p10 = default(double?), double? p25 = default(double?), double? p50 = default(double?), double? p75 = default(double?), double? p90 = default(double?), double? p95 = default(double?), double? p99 = default(double?))
            : base(_count, average, maximum, minimum, timestamp, total)
        {
            P10 = p10;
            P25 = p25;
            P50 = p50;
            P75 = p75;
            P90 = p90;
            P95 = p95;
            P99 = p99;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the 10th percentile value for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "P10")]
        public double? P10 { get; private set; }

        /// <summary>
        /// Gets the 25th percentile value for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "P25")]
        public double? P25 { get; private set; }

        /// <summary>
        /// Gets the 50th percentile value for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "P50")]
        public double? P50 { get; private set; }

        /// <summary>
        /// Gets the 75th percentile value for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "P75")]
        public double? P75 { get; private set; }

        /// <summary>
        /// Gets the 90th percentile value for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "P90")]
        public double? P90 { get; private set; }

        /// <summary>
        /// Gets the 95th percentile value for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "P95")]
        public double? P95 { get; private set; }

        /// <summary>
        /// Gets the 99th percentile value for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "P99")]
        public double? P99 { get; private set; }

    }
}
