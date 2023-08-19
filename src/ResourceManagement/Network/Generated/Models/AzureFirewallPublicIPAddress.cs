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
    /// Public IP Address associated with azure firewall.
    /// </summary>
    public partial class AzureFirewallPublicIPAddress
    {
        /// <summary>
        /// Initializes a new instance of the AzureFirewallPublicIPAddress
        /// class.
        /// </summary>
        public AzureFirewallPublicIPAddress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureFirewallPublicIPAddress
        /// class.
        /// </summary>
        /// <param name="address">Public IP Address value.</param>
        public AzureFirewallPublicIPAddress(string address = default(string))
        {
            Address = address;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets public IP Address value.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

    }
}
