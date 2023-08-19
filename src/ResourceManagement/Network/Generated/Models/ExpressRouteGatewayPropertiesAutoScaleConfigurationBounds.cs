// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Minimum and maximum number of scale units to deploy.
    /// </summary>
    public partial class ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds class.
        /// </summary>
        public ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds class.
        /// </summary>
        /// <param name="min">Minimum number of scale units deployed for
        /// ExpressRoute gateway.</param>
        /// <param name="max">Maximum number of scale units deployed for
        /// ExpressRoute gateway.</param>
        public ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds(int? min = default(int?), int? max = default(int?))
        {
            Min = min;
            Max = max;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets minimum number of scale units deployed for
        /// ExpressRoute gateway.
        /// </summary>
        [JsonProperty(PropertyName = "min")]
        public int? Min { get; set; }

        /// <summary>
        /// Gets or sets maximum number of scale units deployed for
        /// ExpressRoute gateway.
        /// </summary>
        [JsonProperty(PropertyName = "max")]
        public int? Max { get; set; }

    }
}
