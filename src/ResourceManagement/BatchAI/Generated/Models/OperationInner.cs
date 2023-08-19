// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A REST API operation.
    /// </summary>
    /// <remarks>
    /// Details of a REST API operation
    /// </remarks>
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
        /// <param name="name">The operation name.</param>
        /// <param name="display">The object that describes the
        /// operation.</param>
        /// <param name="origin">The intended executor of the
        /// operation.</param>
        /// <param name="properties">Properties of the operation.</param>
        public OperationInner(string name = default(string), OperationDisplay display = default(OperationDisplay), string origin = default(string), object properties = default(object))
        {
            Name = name;
            Display = display;
            Origin = origin;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the operation name.
        /// </summary>
        /// <remarks>
        /// This is of the format {provider}/{resource}/{operation}
        /// </remarks>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the object that describes the operation.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public OperationDisplay Display { get; set; }

        /// <summary>
        /// Gets the intended executor of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; private set; }

        /// <summary>
        /// Gets or sets properties of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

    }
}
