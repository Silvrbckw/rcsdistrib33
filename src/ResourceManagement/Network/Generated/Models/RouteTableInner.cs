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
    /// Route table resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RouteTableInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the RouteTableInner class.
        /// </summary>
        public RouteTableInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RouteTableInner class.
        /// </summary>
        /// <param name="routes">Collection of routes contained within a route
        /// table.</param>
        /// <param name="subnets">A collection of references to
        /// subnets.</param>
        /// <param name="disableBgpRoutePropagation">Whether to disable the
        /// routes learned by BGP on that route table. True means
        /// disable.</param>
        /// <param name="provisioningState">The provisioning state of the route
        /// table resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public RouteTableInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<RouteInner> routes = default(IList<RouteInner>), IList<SubnetInner> subnets = default(IList<SubnetInner>), bool? disableBgpRoutePropagation = default(bool?), ProvisioningState provisioningState = default(ProvisioningState), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            Routes = routes;
            Subnets = subnets;
            DisableBgpRoutePropagation = disableBgpRoutePropagation;
            ProvisioningState = provisioningState;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets collection of routes contained within a route table.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routes")]
        public IList<RouteInner> Routes { get; set; }

        /// <summary>
        /// Gets a collection of references to subnets.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnets")]
        public IList<SubnetInner> Subnets { get; private set; }

        /// <summary>
        /// Gets or sets whether to disable the routes learned by BGP on that
        /// route table. True means disable.
        /// </summary>
        [JsonProperty(PropertyName = "properties.disableBgpRoutePropagation")]
        public bool? DisableBgpRoutePropagation { get; set; }

        /// <summary>
        /// Gets the provisioning state of the route table resource. Possible
        /// values include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

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
            if (Routes != null)
            {
                foreach (var element in Routes)
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