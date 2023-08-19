// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The list of available upgrade versions.
    /// </summary>
    public partial class ManagedClusterPoolUpgradeProfile
    {
        /// <summary>
        /// Initializes a new instance of the ManagedClusterPoolUpgradeProfile
        /// class.
        /// </summary>
        public ManagedClusterPoolUpgradeProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedClusterPoolUpgradeProfile
        /// class.
        /// </summary>
        /// <param name="kubernetesVersion">Kubernetes version (major, minor,
        /// patch).</param>
        /// <param name="osType">OsType to be used to specify os type. Choose
        /// from Linux and Windows. Default to Linux. Possible values include:
        /// 'Linux', 'Windows'</param>
        /// <param name="name">Pool name.</param>
        /// <param name="upgrades">List of orchestrator types and versions
        /// available for upgrade.</param>
        public ManagedClusterPoolUpgradeProfile(string kubernetesVersion, OSType osType, string name = default(string), IList<ManagedClusterPoolUpgradeProfileUpgradesItem> upgrades = default(IList<ManagedClusterPoolUpgradeProfileUpgradesItem>))
        {
            KubernetesVersion = kubernetesVersion;
            Name = name;
            OsType = osType;
            Upgrades = upgrades;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets kubernetes version (major, minor, patch).
        /// </summary>
        [JsonProperty(PropertyName = "kubernetesVersion")]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// Gets or sets pool name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets osType to be used to specify os type. Choose from
        /// Linux and Windows. Default to Linux. Possible values include:
        /// 'Linux', 'Windows'
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public OSType OsType { get; set; }

        /// <summary>
        /// Gets or sets list of orchestrator types and versions available for
        /// upgrade.
        /// </summary>
        [JsonProperty(PropertyName = "upgrades")]
        public IList<ManagedClusterPoolUpgradeProfileUpgradesItem> Upgrades { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KubernetesVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KubernetesVersion");
            }
            if (OsType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OsType");
            }
        }
    }
}
