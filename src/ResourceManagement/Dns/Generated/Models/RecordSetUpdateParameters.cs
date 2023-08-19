// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Dns.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters supplied to update a record set.
    /// </summary>
    public partial class RecordSetUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the RecordSetUpdateParameters class.
        /// </summary>
        public RecordSetUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecordSetUpdateParameters class.
        /// </summary>
        /// <param name="recordSet">Specifies information about the record set
        /// being updated.</param>
        public RecordSetUpdateParameters(RecordSetInner recordSet = default(RecordSetInner))
        {
            RecordSet = recordSet;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies information about the record set being
        /// updated.
        /// </summary>
        [JsonProperty(PropertyName = "RecordSet")]
        public RecordSetInner RecordSet { get; set; }

    }
}
