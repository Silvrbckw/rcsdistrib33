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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Country details.
    /// </summary>
    public partial class AvailableProvidersListCountry
    {
        /// <summary>
        /// Initializes a new instance of the AvailableProvidersListCountry
        /// class.
        /// </summary>
        public AvailableProvidersListCountry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailableProvidersListCountry
        /// class.
        /// </summary>
        /// <param name="countryName">The country name.</param>
        /// <param name="providers">A list of Internet service
        /// providers.</param>
        /// <param name="states">List of available states in the
        /// country.</param>
        public AvailableProvidersListCountry(string countryName = default(string), IList<string> providers = default(IList<string>), IList<AvailableProvidersListState> states = default(IList<AvailableProvidersListState>))
        {
            CountryName = countryName;
            Providers = providers;
            States = states;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the country name.
        /// </summary>
        [JsonProperty(PropertyName = "countryName")]
        public string CountryName { get; set; }

        /// <summary>
        /// Gets or sets a list of Internet service providers.
        /// </summary>
        [JsonProperty(PropertyName = "providers")]
        public IList<string> Providers { get; set; }

        /// <summary>
        /// Gets or sets list of available states in the country.
        /// </summary>
        [JsonProperty(PropertyName = "states")]
        public IList<AvailableProvidersListState> States { get; set; }

    }
}
