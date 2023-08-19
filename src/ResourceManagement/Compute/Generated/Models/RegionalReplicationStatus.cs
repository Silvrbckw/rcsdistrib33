// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This is the regional replication status.
    /// </summary>
    public partial class RegionalReplicationStatus
    {
        /// <summary>
        /// Initializes a new instance of the RegionalReplicationStatus class.
        /// </summary>
        public RegionalReplicationStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegionalReplicationStatus class.
        /// </summary>
        /// <param name="region">The region to which the gallery Image Version
        /// is being replicated to.</param>
        /// <param name="state">This is the regional replication state.
        /// Possible values include: 'Unknown', 'Replicating', 'Completed',
        /// 'Failed'</param>
        /// <param name="details">The details of the replication
        /// status.</param>
        /// <param name="progress">It indicates progress of the replication
        /// job.</param>
        public RegionalReplicationStatus(string region = default(string), ReplicationState state = default(ReplicationState), string details = default(string), int? progress = default(int?))
        {
            Region = region;
            State = state;
            Details = details;
            Progress = progress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the region to which the gallery Image Version is being
        /// replicated to.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; private set; }

        /// <summary>
        /// Gets this is the regional replication state. Possible values
        /// include: 'Unknown', 'Replicating', 'Completed', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public ReplicationState State { get; private set; }

        /// <summary>
        /// Gets the details of the replication status.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string Details { get; private set; }

        /// <summary>
        /// Gets it indicates progress of the replication job.
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public int? Progress { get; private set; }

    }
}
