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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An instance failover group.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class InstanceFailoverGroupInner : ProxyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the InstanceFailoverGroupInner class.
        /// </summary>
        public InstanceFailoverGroupInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InstanceFailoverGroupInner class.
        /// </summary>
        /// <param name="readWriteEndpoint">Read-write endpoint of the failover
        /// group instance.</param>
        /// <param name="partnerRegions">Partner region information for the
        /// failover group.</param>
        /// <param name="managedInstancePairs">List of managed instance pairs
        /// in the failover group.</param>
        /// <param name="readOnlyEndpoint">Read-only endpoint of the failover
        /// group instance.</param>
        /// <param name="replicationRole">Local replication role of the
        /// failover group instance. Possible values include: 'Primary',
        /// 'Secondary'</param>
        /// <param name="replicationState">Replication state of the failover
        /// group instance.</param>
        public InstanceFailoverGroupInner(InstanceFailoverGroupReadWriteEndpoint readWriteEndpoint, IList<PartnerRegionInfo> partnerRegions, IList<ManagedInstancePairInfo> managedInstancePairs, string id = default(string), string name = default(string), string type = default(string), InstanceFailoverGroupReadOnlyEndpoint readOnlyEndpoint = default(InstanceFailoverGroupReadOnlyEndpoint), InstanceFailoverGroupReplicationRole replicationRole = default(InstanceFailoverGroupReplicationRole), string replicationState = default(string))
            : base(id, name, type)
        {
            ReadWriteEndpoint = readWriteEndpoint;
            ReadOnlyEndpoint = readOnlyEndpoint;
            ReplicationRole = replicationRole;
            ReplicationState = replicationState;
            PartnerRegions = partnerRegions;
            ManagedInstancePairs = managedInstancePairs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets read-write endpoint of the failover group instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.readWriteEndpoint")]
        public InstanceFailoverGroupReadWriteEndpoint ReadWriteEndpoint { get; set; }

        /// <summary>
        /// Gets or sets read-only endpoint of the failover group instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.readOnlyEndpoint")]
        public InstanceFailoverGroupReadOnlyEndpoint ReadOnlyEndpoint { get; set; }

        /// <summary>
        /// Gets local replication role of the failover group instance.
        /// Possible values include: 'Primary', 'Secondary'
        /// </summary>
        [JsonProperty(PropertyName = "properties.replicationRole")]
        public InstanceFailoverGroupReplicationRole ReplicationRole { get; private set; }

        /// <summary>
        /// Gets replication state of the failover group instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.replicationState")]
        public string ReplicationState { get; private set; }

        /// <summary>
        /// Gets or sets partner region information for the failover group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerRegions")]
        public IList<PartnerRegionInfo> PartnerRegions { get; set; }

        /// <summary>
        /// Gets or sets list of managed instance pairs in the failover group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedInstancePairs")]
        public IList<ManagedInstancePairInfo> ManagedInstancePairs { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ReadWriteEndpoint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReadWriteEndpoint");
            }
            if (PartnerRegions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PartnerRegions");
            }
            if (ManagedInstancePairs == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ManagedInstancePairs");
            }
            if (ReadWriteEndpoint != null)
            {
                ReadWriteEndpoint.Validate();
            }
        }
    }
}
