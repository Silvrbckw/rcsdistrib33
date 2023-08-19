// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Resource group information.
    /// </summary>
    public partial class ResourceGroupInner : Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ResourceGroupInner class.
        /// </summary>
        public ResourceGroupInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceGroupInner class.
        /// </summary>
        /// <param name="properties">The resource group properties.</param>
        /// <param name="managedBy">The ID of the resource that manages this
        /// resource group.</param>
        public ResourceGroupInner(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ResourceGroupProperties properties = default(ResourceGroupProperties), string managedBy = default(string))
            : base(location, id, name, type, tags)
        {
            Properties = properties;
            ManagedBy = managedBy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource group properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ResourceGroupProperties Properties { get; set; }

        /// <summary>
        /// Gets or sets the ID of the resource that manages this resource
        /// group.
        /// </summary>
        [JsonProperty(PropertyName = "managedBy")]
        public string ManagedBy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}