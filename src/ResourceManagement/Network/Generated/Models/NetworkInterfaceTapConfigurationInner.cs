// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Tap configuration in a Network Interface.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NetworkInterfaceTapConfigurationInner : Management.ResourceManager.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// NetworkInterfaceTapConfigurationInner class.
        /// </summary>
        public NetworkInterfaceTapConfigurationInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// NetworkInterfaceTapConfigurationInner class.
        /// </summary>
        /// <param name="virtualNetworkTap">The reference of the Virtual
        /// Network Tap resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// network interface tap configuration resource. Possible values
        /// include: 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Sub Resource type.</param>
        public NetworkInterfaceTapConfigurationInner(string id = default(string), Management.ResourceManager.Fluent.SubResource virtualNetworkTap = default(Management.ResourceManager.Fluent.SubResource), ProvisioningState provisioningState = default(ProvisioningState), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            VirtualNetworkTap = virtualNetworkTap;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the reference of the Virtual Network Tap resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkTap")]
        public Management.ResourceManager.Fluent.SubResource VirtualNetworkTap { get; set; }

        /// <summary>
        /// Gets the provisioning state of the network interface tap
        /// configuration resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets sub Resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
