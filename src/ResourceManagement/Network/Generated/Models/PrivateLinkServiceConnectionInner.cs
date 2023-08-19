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
    /// PrivateLinkServiceConnection resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PrivateLinkServiceConnectionInner : Management.ResourceManager.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the PrivateLinkServiceConnectionInner
        /// class.
        /// </summary>
        public PrivateLinkServiceConnectionInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateLinkServiceConnectionInner
        /// class.
        /// </summary>
        /// <param name="provisioningState">The provisioning state of the
        /// private link service connection resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="privateLinkServiceId">The resource id of private link
        /// service.</param>
        /// <param name="groupIds">The ID(s) of the group(s) obtained from the
        /// remote resource that this private endpoint should connect
        /// to.</param>
        /// <param name="requestMessage">A message passed to the owner of the
        /// remote resource with this connection request. Restricted to 140
        /// chars.</param>
        /// <param name="privateLinkServiceConnectionState">A collection of
        /// read-only information about the state of the connection to the
        /// remote resource.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public PrivateLinkServiceConnectionInner(string id = default(string), ProvisioningState provisioningState = default(ProvisioningState), string privateLinkServiceId = default(string), IList<string> groupIds = default(IList<string>), string requestMessage = default(string), PrivateLinkServiceConnectionState privateLinkServiceConnectionState = default(PrivateLinkServiceConnectionState), string name = default(string), string type = default(string), string etag = default(string))
            : base(id)
        {
            ProvisioningState = provisioningState;
            PrivateLinkServiceId = privateLinkServiceId;
            GroupIds = groupIds;
            RequestMessage = requestMessage;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            Name = name;
            Type = type;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning state of the private link service connection
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the resource id of private link service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateLinkServiceId")]
        public string PrivateLinkServiceId { get; set; }

        /// <summary>
        /// Gets or sets the ID(s) of the group(s) obtained from the remote
        /// resource that this private endpoint should connect to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.groupIds")]
        public IList<string> GroupIds { get; set; }

        /// <summary>
        /// Gets or sets a message passed to the owner of the remote resource
        /// with this connection request. Restricted to 140 chars.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestMessage")]
        public string RequestMessage { get; set; }

        /// <summary>
        /// Gets or sets a collection of read-only information about the state
        /// of the connection to the remote resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateLinkServiceConnectionState")]
        public PrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
