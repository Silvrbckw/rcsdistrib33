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
    /// A DDoS custom policy in a resource group.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DdosCustomPolicyInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the DdosCustomPolicyInner class.
        /// </summary>
        public DdosCustomPolicyInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DdosCustomPolicyInner class.
        /// </summary>
        /// <param name="resourceGuid">The resource GUID property of the DDoS
        /// custom policy resource. It uniquely identifies the resource, even
        /// if the user changes its name or migrate the resource across
        /// subscriptions or resource groups.</param>
        /// <param name="provisioningState">The provisioning state of the DDoS
        /// custom policy resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="publicIPAddresses">The list of public IPs associated
        /// with the DDoS custom policy resource. This list is
        /// read-only.</param>
        /// <param name="protocolCustomSettings">The protocol-specific DDoS
        /// policy customization parameters.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public DdosCustomPolicyInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string resourceGuid = default(string), ProvisioningState provisioningState = default(ProvisioningState), IList<Management.ResourceManager.Fluent.SubResource> publicIPAddresses = default(IList<Management.ResourceManager.Fluent.SubResource>), IList<ProtocolCustomSettingsFormat> protocolCustomSettings = default(IList<ProtocolCustomSettingsFormat>), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            PublicIPAddresses = publicIPAddresses;
            ProtocolCustomSettings = protocolCustomSettings;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the resource GUID property of the DDoS custom policy resource.
        /// It uniquely identifies the resource, even if the user changes its
        /// name or migrate the resource across subscriptions or resource
        /// groups.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the DDoS custom policy resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the list of public IPs associated with the DDoS custom policy
        /// resource. This list is read-only.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddresses")]
        public IList<Management.ResourceManager.Fluent.SubResource> PublicIPAddresses { get; private set; }

        /// <summary>
        /// Gets or sets the protocol-specific DDoS policy customization
        /// parameters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocolCustomSettings")]
        public IList<ProtocolCustomSettingsFormat> ProtocolCustomSettings { get; set; }

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