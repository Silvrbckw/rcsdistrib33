// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A short term retention policy.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagedBackupShortTermRetentionPolicyInner : ProxyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedBackupShortTermRetentionPolicyInner class.
        /// </summary>
        public ManagedBackupShortTermRetentionPolicyInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedBackupShortTermRetentionPolicyInner class.
        /// </summary>
        /// <param name="retentionDays">The backup retention period in days.
        /// This is how many days Point-in-Time Restore will be
        /// supported.</param>
        public ManagedBackupShortTermRetentionPolicyInner(string id = default(string), string name = default(string), string type = default(string), int? retentionDays = default(int?))
            : base(id, name, type)
        {
            RetentionDays = retentionDays;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the backup retention period in days. This is how many
        /// days Point-in-Time Restore will be supported.
        /// </summary>
        [JsonProperty(PropertyName = "properties.retentionDays")]
        public int? RetentionDays { get; set; }

    }
}
