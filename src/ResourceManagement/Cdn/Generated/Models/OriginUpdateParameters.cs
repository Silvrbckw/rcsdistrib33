// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Origin properties needed for origin creation or update.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class OriginUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the OriginUpdateParameters class.
        /// </summary>
        public OriginUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OriginUpdateParameters class.
        /// </summary>
        /// <param name="hostName">The address of the origin. Domain names,
        /// IPv4 addresses, and IPv6 addresses are supported.</param>
        /// <param name="httpPort">The value of the HTTP port. Must be between
        /// 1 and 65535.</param>
        /// <param name="httpsPort">The value of the HTTPS port. Must be
        /// between 1 and 65535.</param>
        public OriginUpdateParameters(string hostName = default(string), int? httpPort = default(int?), int? httpsPort = default(int?))
        {
            HostName = hostName;
            HttpPort = httpPort;
            HttpsPort = httpsPort;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the address of the origin. Domain names, IPv4
        /// addresses, and IPv6 addresses are supported.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets the value of the HTTP port. Must be between 1 and
        /// 65535.
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpPort")]
        public int? HttpPort { get; set; }

        /// <summary>
        /// Gets or sets the value of the HTTPS port. Must be between 1 and
        /// 65535.
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpsPort")]
        public int? HttpsPort { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (HttpPort > 65535)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "HttpPort", 65535);
            }
            if (HttpPort < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "HttpPort", 1);
            }
            if (HttpsPort > 65535)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "HttpsPort", 65535);
            }
            if (HttpsPort < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "HttpsPort", 1);
            }
        }
    }
}
