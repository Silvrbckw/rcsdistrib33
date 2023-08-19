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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// P2SVpnGateway Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class P2SVpnGatewayInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the P2SVpnGatewayInner class.
        /// </summary>
        public P2SVpnGatewayInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the P2SVpnGatewayInner class.
        /// </summary>
        /// <param name="virtualHub">The VirtualHub to which the gateway
        /// belongs.</param>
        /// <param name="p2SConnectionConfigurations">List of all p2s
        /// connection configurations of the gateway.</param>
        /// <param name="provisioningState">The provisioning state of the P2S
        /// VPN gateway resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="vpnGatewayScaleUnit">The scale unit for this p2s vpn
        /// gateway.</param>
        /// <param name="vpnServerConfiguration">The VpnServerConfiguration to
        /// which the p2sVpnGateway is attached to.</param>
        /// <param name="vpnClientConnectionHealth">All P2S VPN clients'
        /// connection health status.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public P2SVpnGatewayInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Management.ResourceManager.Fluent.SubResource virtualHub = default(Management.ResourceManager.Fluent.SubResource), IList<P2SConnectionConfigurationInner> p2SConnectionConfigurations = default(IList<P2SConnectionConfigurationInner>), ProvisioningState provisioningState = default(ProvisioningState), int? vpnGatewayScaleUnit = default(int?), Management.ResourceManager.Fluent.SubResource vpnServerConfiguration = default(Management.ResourceManager.Fluent.SubResource), VpnClientConnectionHealth vpnClientConnectionHealth = default(VpnClientConnectionHealth), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            VirtualHub = virtualHub;
            P2SConnectionConfigurations = p2SConnectionConfigurations;
            ProvisioningState = provisioningState;
            VpnGatewayScaleUnit = vpnGatewayScaleUnit;
            VpnServerConfiguration = vpnServerConfiguration;
            VpnClientConnectionHealth = vpnClientConnectionHealth;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the VirtualHub to which the gateway belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualHub")]
        public Management.ResourceManager.Fluent.SubResource VirtualHub { get; set; }

        /// <summary>
        /// Gets or sets list of all p2s connection configurations of the
        /// gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.p2SConnectionConfigurations")]
        public IList<P2SConnectionConfigurationInner> P2SConnectionConfigurations { get; set; }

        /// <summary>
        /// Gets the provisioning state of the P2S VPN gateway resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the scale unit for this p2s vpn gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnGatewayScaleUnit")]
        public int? VpnGatewayScaleUnit { get; set; }

        /// <summary>
        /// Gets or sets the VpnServerConfiguration to which the p2sVpnGateway
        /// is attached to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnServerConfiguration")]
        public Management.ResourceManager.Fluent.SubResource VpnServerConfiguration { get; set; }

        /// <summary>
        /// Gets all P2S VPN clients' connection health status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnClientConnectionHealth")]
        public VpnClientConnectionHealth VpnClientConnectionHealth { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}