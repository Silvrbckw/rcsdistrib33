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
    using System.Linq;

    /// <summary>
    /// This is the disk image encryption base class.
    /// </summary>
    public partial class DiskImageEncryption
    {
        /// <summary>
        /// Initializes a new instance of the DiskImageEncryption class.
        /// </summary>
        public DiskImageEncryption()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskImageEncryption class.
        /// </summary>
        /// <param name="diskEncryptionSetId">A relative URI containing the
        /// resource ID of the disk encryption set.</param>
        public DiskImageEncryption(string diskEncryptionSetId = default(string))
        {
            DiskEncryptionSetId = diskEncryptionSetId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a relative URI containing the resource ID of the disk
        /// encryption set.
        /// </summary>
        [JsonProperty(PropertyName = "diskEncryptionSetId")]
        public string DiskEncryptionSetId { get; set; }

    }
}
