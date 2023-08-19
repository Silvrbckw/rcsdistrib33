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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Database metrics.
    /// </summary>
    public partial class Metric
    {
        /// <summary>
        /// Initializes a new instance of the Metric class.
        /// </summary>
        public Metric()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Metric class.
        /// </summary>
        /// <param name="startTime">The start time for the metric (ISO-8601
        /// format).</param>
        /// <param name="endTime">The end time for the metric (ISO-8601
        /// format).</param>
        /// <param name="timeGrain">The time step to be used to summarize the
        /// metric values.</param>
        /// <param name="unit">The unit of the metric. Possible values include:
        /// 'count', 'bytes', 'seconds', 'percent', 'countPerSecond',
        /// 'bytesPerSecond'</param>
        /// <param name="name">The name information for the metric.</param>
        /// <param name="metricValues">The metric values for the specified time
        /// window and timestep.</param>
        public Metric(System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string timeGrain = default(string), UnitType unit = default(UnitType), MetricName name = default(MetricName), IList<MetricValue> metricValues = default(IList<MetricValue>))
        {
            StartTime = startTime;
            EndTime = endTime;
            TimeGrain = timeGrain;
            Unit = unit;
            Name = name;
            MetricValues = metricValues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the start time for the metric (ISO-8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets the end time for the metric (ISO-8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets the time step to be used to summarize the metric values.
        /// </summary>
        [JsonProperty(PropertyName = "timeGrain")]
        public string TimeGrain { get; private set; }

        /// <summary>
        /// Gets the unit of the metric. Possible values include: 'count',
        /// 'bytes', 'seconds', 'percent', 'countPerSecond', 'bytesPerSecond'
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public UnitType Unit { get; private set; }

        /// <summary>
        /// Gets the name information for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public MetricName Name { get; private set; }

        /// <summary>
        /// Gets the metric values for the specified time window and timestep.
        /// </summary>
        [JsonProperty(PropertyName = "metricValues")]
        public IList<MetricValue> MetricValues { get; private set; }

    }
}
