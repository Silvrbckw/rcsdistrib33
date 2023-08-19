// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The source image from which the Image Version is going to be created.
    /// </summary>
    public partial class GalleryArtifactSource
    {
        /// <summary>
        /// Initializes a new instance of the GalleryArtifactSource class.
        /// </summary>
        public GalleryArtifactSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GalleryArtifactSource class.
        /// </summary>
        public GalleryArtifactSource(ManagedArtifact managedImage)
        {
            ManagedImage = managedImage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "managedImage")]
        public ManagedArtifact ManagedImage { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ManagedImage == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ManagedImage");
            }
            if (ManagedImage != null)
            {
                ManagedImage.Validate();
            }
        }
    }
}
