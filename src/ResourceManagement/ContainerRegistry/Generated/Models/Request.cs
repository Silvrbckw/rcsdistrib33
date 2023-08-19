// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The request that generated the event.
    /// </summary>
    public partial class Request
    {
        /// <summary>
        /// Initializes a new instance of the Request class.
        /// </summary>
        public Request()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Request class.
        /// </summary>
        /// <param name="id">The ID of the request that initiated the
        /// event.</param>
        /// <param name="addr">The IP or hostname and possibly port of the
        /// client connection that initiated the event. This is the RemoteAddr
        /// from the standard http request.</param>
        /// <param name="host">The externally accessible hostname of the
        /// registry instance, as specified by the http host header on incoming
        /// requests.</param>
        /// <param name="method">The request method that generated the
        /// event.</param>
        /// <param name="useragent">The user agent header of the
        /// request.</param>
        public Request(string id = default(string), string addr = default(string), string host = default(string), string method = default(string), string useragent = default(string))
        {
            Id = id;
            Addr = addr;
            Host = host;
            Method = method;
            Useragent = useragent;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the request that initiated the event.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the IP or hostname and possibly port of the client
        /// connection that initiated the event. This is the RemoteAddr from
        /// the standard http request.
        /// </summary>
        [JsonProperty(PropertyName = "addr")]
        public string Addr { get; set; }

        /// <summary>
        /// Gets or sets the externally accessible hostname of the registry
        /// instance, as specified by the http host header on incoming
        /// requests.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }

        /// <summary>
        /// Gets or sets the request method that generated the event.
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets the user agent header of the request.
        /// </summary>
        [JsonProperty(PropertyName = "useragent")]
        public string Useragent { get; set; }

    }
}
