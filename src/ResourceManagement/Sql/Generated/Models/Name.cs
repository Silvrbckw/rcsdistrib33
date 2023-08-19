// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ARM Usage Name
    /// </summary>
    public partial class Name
    {
        /// <summary>
        /// Initializes a new instance of the Name class.
        /// </summary>
        public Name()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Name class.
        /// </summary>
        /// <param name="value">Usage name value</param>
        /// <param name="localizedValue">Usage name localized value.</param>
        public Name(string value = default(string), string localizedValue = default(string))
        {
            Value = value;
            LocalizedValue = localizedValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets usage name value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets usage name localized value.
        /// </summary>
        [JsonProperty(PropertyName = "localizedValue")]
        public string LocalizedValue { get; set; }

    }
}
