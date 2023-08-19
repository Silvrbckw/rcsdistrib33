// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The metric alert resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MetricAlertResourceInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the MetricAlertResourceInner class.
        /// </summary>
        public MetricAlertResourceInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricAlertResourceInner class.
        /// </summary>
        /// <param name="description">the description of the metric alert that
        /// will be included in the alert email.</param>
        /// <param name="severity">Alert severity {0, 1, 2, 3, 4}</param>
        /// <param name="enabled">the flag that indicates whether the metric
        /// alert is enabled.</param>
        /// <param name="evaluationFrequency">how often the metric alert is
        /// evaluated represented in ISO 8601 duration format.</param>
        /// <param name="windowSize">the period of time (in ISO 8601 duration
        /// format) that is used to monitor alert activity based on the
        /// threshold.</param>
        /// <param name="criteria">defines the specific alert criteria
        /// information.</param>
        /// <param name="scopes">the list of resource id's that this metric
        /// alert is scoped to.</param>
        /// <param name="targetResourceType">the resource type of the target
        /// resource(s) on which the alert is created/updated. Mandatory for
        /// MultipleResourceMultipleMetricCriteria.</param>
        /// <param name="targetResourceRegion">the region of the target
        /// resource(s) on which the alert is created/updated. Mandatory for
        /// MultipleResourceMultipleMetricCriteria.</param>
        /// <param name="autoMitigate">the flag that indicates whether the
        /// alert should be auto resolved or not. The default is true.</param>
        /// <param name="actions">the array of actions that are performed when
        /// the alert rule becomes active, and when an alert condition is
        /// resolved.</param>
        /// <param name="lastUpdatedTime">Last time the rule was updated in
        /// ISO8601 format.</param>
        public MetricAlertResourceInner(string location, string description, int severity, bool enabled, System.TimeSpan evaluationFrequency, System.TimeSpan windowSize, MetricAlertCriteria criteria, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<string> scopes = default(IList<string>), string targetResourceType = default(string), string targetResourceRegion = default(string), bool? autoMitigate = default(bool?), IList<MetricAlertAction> actions = default(IList<MetricAlertAction>), System.DateTime? lastUpdatedTime = default(System.DateTime?))
            : base(location, id, name, type, tags)
        {
            Description = description;
            Severity = severity;
            Enabled = enabled;
            Scopes = scopes;
            EvaluationFrequency = evaluationFrequency;
            WindowSize = windowSize;
            TargetResourceType = targetResourceType;
            TargetResourceRegion = targetResourceRegion;
            Criteria = criteria;
            AutoMitigate = autoMitigate;
            Actions = actions;
            LastUpdatedTime = lastUpdatedTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the description of the metric alert that will be
        /// included in the alert email.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets alert severity {0, 1, 2, 3, 4}
        /// </summary>
        [JsonProperty(PropertyName = "properties.severity")]
        public int Severity { get; set; }

        /// <summary>
        /// Gets or sets the flag that indicates whether the metric alert is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the list of resource id's that this metric alert is
        /// scoped to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scopes")]
        public IList<string> Scopes { get; set; }

        /// <summary>
        /// Gets or sets how often the metric alert is evaluated represented in
        /// ISO 8601 duration format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.evaluationFrequency")]
        public System.TimeSpan EvaluationFrequency { get; set; }

        /// <summary>
        /// Gets or sets the period of time (in ISO 8601 duration format) that
        /// is used to monitor alert activity based on the threshold.
        /// </summary>
        [JsonProperty(PropertyName = "properties.windowSize")]
        public System.TimeSpan WindowSize { get; set; }

        /// <summary>
        /// Gets or sets the resource type of the target resource(s) on which
        /// the alert is created/updated. Mandatory for
        /// MultipleResourceMultipleMetricCriteria.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetResourceType")]
        public string TargetResourceType { get; set; }

        /// <summary>
        /// Gets or sets the region of the target resource(s) on which the
        /// alert is created/updated. Mandatory for
        /// MultipleResourceMultipleMetricCriteria.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetResourceRegion")]
        public string TargetResourceRegion { get; set; }

        /// <summary>
        /// Gets or sets defines the specific alert criteria information.
        /// </summary>
        [JsonProperty(PropertyName = "properties.criteria")]
        public MetricAlertCriteria Criteria { get; set; }

        /// <summary>
        /// Gets or sets the flag that indicates whether the alert should be
        /// auto resolved or not. The default is true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoMitigate")]
        public bool? AutoMitigate { get; set; }

        /// <summary>
        /// Gets or sets the array of actions that are performed when the alert
        /// rule becomes active, and when an alert condition is resolved.
        /// </summary>
        [JsonProperty(PropertyName = "properties.actions")]
        public IList<MetricAlertAction> Actions { get; set; }

        /// <summary>
        /// Gets last time the rule was updated in ISO8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastUpdatedTime")]
        public System.DateTime? LastUpdatedTime { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Description == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Description");
            }
            if (Criteria == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Criteria");
            }
        }
    }
}
