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
    /// A ExpressRouteResourceProvider object.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ExpressRouteServiceProviderInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteServiceProviderInner
        /// class.
        /// </summary>
        public ExpressRouteServiceProviderInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteServiceProviderInner
        /// class.
        /// </summary>
        /// <param name="peeringLocations">A list of peering locations.</param>
        /// <param name="bandwidthsOffered">A list of bandwidths
        /// offered.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// express route service provider resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        public ExpressRouteServiceProviderInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<string> peeringLocations = default(IList<string>), IList<ExpressRouteServiceProviderBandwidthsOffered> bandwidthsOffered = default(IList<ExpressRouteServiceProviderBandwidthsOffered>), ProvisioningState provisioningState = default(ProvisioningState))
            : base(location, id, name, type, tags)
        {
            PeeringLocations = peeringLocations;
            BandwidthsOffered = bandwidthsOffered;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of peering locations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peeringLocations")]
        public IList<string> PeeringLocations { get; set; }

        /// <summary>
        /// Gets or sets a list of bandwidths offered.
        /// </summary>
        [JsonProperty(PropertyName = "properties.bandwidthsOffered")]
        public IList<ExpressRouteServiceProviderBandwidthsOffered> BandwidthsOffered { get; set; }

        /// <summary>
        /// Gets the provisioning state of the express route service provider
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

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
