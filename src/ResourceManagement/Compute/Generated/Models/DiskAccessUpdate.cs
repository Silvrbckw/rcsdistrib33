// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Used for updating a disk access resource.
    /// </summary>
    public partial class DiskAccessUpdate
    {
        /// <summary>
        /// Initializes a new instance of the DiskAccessUpdate class.
        /// </summary>
        public DiskAccessUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskAccessUpdate class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        public DiskAccessUpdate(IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
