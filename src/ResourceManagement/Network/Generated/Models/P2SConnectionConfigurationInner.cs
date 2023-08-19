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
    /// P2SConnectionConfiguration Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class P2SConnectionConfigurationInner : Management.ResourceManager.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the P2SConnectionConfigurationInner
        /// class.
        /// </summary>
        public P2SConnectionConfigurationInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the P2SConnectionConfigurationInner
        /// class.
        /// </summary>
        /// <param name="vpnClientAddressPool">The reference of the address
        /// space resource which represents Address space for P2S
        /// VpnClient.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// P2SConnectionConfiguration resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public P2SConnectionConfigurationInner(string id = default(string), AddressSpace vpnClientAddressPool = default(AddressSpace), ProvisioningState provisioningState = default(ProvisioningState), string name = default(string), string etag = default(string))
            : base(id)
        {
            VpnClientAddressPool = vpnClientAddressPool;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the reference of the address space resource which
        /// represents Address space for P2S VpnClient.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnClientAddressPool")]
        public AddressSpace VpnClientAddressPool { get; set; }

        /// <summary>
        /// Gets the provisioning state of the P2SConnectionConfiguration
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
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

    }
}
