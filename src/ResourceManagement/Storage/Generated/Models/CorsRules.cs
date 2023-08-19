// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Sets the CORS rules. You can include up to five CorsRule elements in
    /// the request.
    /// </summary>
    public partial class CorsRules
    {
        /// <summary>
        /// Initializes a new instance of the CorsRules class.
        /// </summary>
        public CorsRules()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CorsRules class.
        /// </summary>
        /// <param name="corsRulesProperty">The List of CORS rules. You can
        /// include up to five CorsRule elements in the request. </param>
        public CorsRules(IList<CorsRule> corsRulesProperty = default(IList<CorsRule>))
        {
            CorsRulesProperty = corsRulesProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the List of CORS rules. You can include up to five
        /// CorsRule elements in the request.
        /// </summary>
        [JsonProperty(PropertyName = "corsRules")]
        public IList<CorsRule> CorsRulesProperty { get; set; }

    }
}
