// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Site seal
    /// </summary>
    public partial class SiteSealInner
    {
        /// <summary>
        /// Initializes a new instance of the SiteSealInner class.
        /// </summary>
        public SiteSealInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SiteSealInner class.
        /// </summary>
        /// <param name="html">HTML snippet</param>
        public SiteSealInner(string html)
        {
            Html = html;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets HTML snippet
        /// </summary>
        [JsonProperty(PropertyName = "html")]
        public string Html { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Html == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Html");
            }
        }
    }
}
