// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// CDN REST API operation
    /// </summary>
    public partial class OperationInner
    {
        /// <summary>
        /// Initializes a new instance of the OperationInner class.
        /// </summary>
        public OperationInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationInner class.
        /// </summary>
        /// <param name="name">Operation name:
        /// {provider}/{resource}/{operation}</param>
        /// <param name="display">The object that represents the
        /// operation.</param>
        public OperationInner(string name = default(string), OperationDisplay display = default(OperationDisplay))
        {
            Name = name;
            Display = display;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets operation name: {provider}/{resource}/{operation}
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the object that represents the operation.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public OperationDisplay Display { get; set; }

    }
}
