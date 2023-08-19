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
    /// ExpressRoute gateway resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ExpressRouteGatewayInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteGatewayInner class.
        /// </summary>
        public ExpressRouteGatewayInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteGatewayInner class.
        /// </summary>
        /// <param name="virtualHub">The Virtual Hub where the ExpressRoute
        /// gateway is or will be deployed.</param>
        /// <param name="autoScaleConfiguration">Configuration for auto
        /// scaling.</param>
        /// <param name="expressRouteConnections">List of ExpressRoute
        /// connections to the ExpressRoute gateway.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// express route gateway resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public ExpressRouteGatewayInner(VirtualHubId virtualHub, string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ExpressRouteGatewayPropertiesAutoScaleConfiguration autoScaleConfiguration = default(ExpressRouteGatewayPropertiesAutoScaleConfiguration), IList<ExpressRouteConnectionInner> expressRouteConnections = default(IList<ExpressRouteConnectionInner>), ProvisioningState provisioningState = default(ProvisioningState), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            AutoScaleConfiguration = autoScaleConfiguration;
            ExpressRouteConnections = expressRouteConnections;
            ProvisioningState = provisioningState;
            VirtualHub = virtualHub;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets configuration for auto scaling.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoScaleConfiguration")]
        public ExpressRouteGatewayPropertiesAutoScaleConfiguration AutoScaleConfiguration { get; set; }

        /// <summary>
        /// Gets list of ExpressRoute connections to the ExpressRoute gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expressRouteConnections")]
        public IList<ExpressRouteConnectionInner> ExpressRouteConnections { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the express route gateway resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the Virtual Hub where the ExpressRoute gateway is or
        /// will be deployed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualHub")]
        public VirtualHubId VirtualHub { get; set; }

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
            if (VirtualHub == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VirtualHub");
            }
            if (ExpressRouteConnections != null)
            {
                foreach (var element in ExpressRouteConnections)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}