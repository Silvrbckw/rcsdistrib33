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
    /// Describes the basic gallery artifact publishing profile.
    /// </summary>
    public partial class GalleryArtifactPublishingProfileBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GalleryArtifactPublishingProfileBase class.
        /// </summary>
        public GalleryArtifactPublishingProfileBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GalleryArtifactPublishingProfileBase class.
        /// </summary>
        /// <param name="targetRegions">The target regions where the Image
        /// Version is going to be replicated to. This property is
        /// updatable.</param>
        /// <param name="replicaCount">The number of replicas of the Image
        /// Version to be created per region. This property would take effect
        /// for a region when regionalReplicaCount is not specified. This
        /// property is updatable.</param>
        /// <param name="excludeFromLatest">If set to true, Virtual Machines
        /// deployed from the latest version of the Image Definition won't use
        /// this Image Version.</param>
        /// <param name="publishedDate">The timestamp for when the gallery
        /// Image Version is published.</param>
        /// <param name="endOfLifeDate">The end of life date of the gallery
        /// Image Version. This property can be used for decommissioning
        /// purposes. This property is updatable.</param>
        /// <param name="storageAccountType">Specifies the storage account type
        /// to be used to store the image. This property is not updatable.
        /// Possible values include: 'Standard_LRS', 'Standard_ZRS',
        /// 'Premium_LRS'</param>
        public GalleryArtifactPublishingProfileBase(IList<TargetRegion> targetRegions = default(IList<TargetRegion>), int? replicaCount = default(int?), bool? excludeFromLatest = default(bool?), System.DateTime? publishedDate = default(System.DateTime?), System.DateTime? endOfLifeDate = default(System.DateTime?), StorageAccountType storageAccountType = default(StorageAccountType))
        {
            TargetRegions = targetRegions;
            ReplicaCount = replicaCount;
            ExcludeFromLatest = excludeFromLatest;
            PublishedDate = publishedDate;
            EndOfLifeDate = endOfLifeDate;
            StorageAccountType = storageAccountType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the target regions where the Image Version is going to
        /// be replicated to. This property is updatable.
        /// </summary>
        [JsonProperty(PropertyName = "targetRegions")]
        public IList<TargetRegion> TargetRegions { get; set; }

        /// <summary>
        /// Gets or sets the number of replicas of the Image Version to be
        /// created per region. This property would take effect for a region
        /// when regionalReplicaCount is not specified. This property is
        /// updatable.
        /// </summary>
        [JsonProperty(PropertyName = "replicaCount")]
        public int? ReplicaCount { get; set; }

        /// <summary>
        /// Gets or sets if set to true, Virtual Machines deployed from the
        /// latest version of the Image Definition won't use this Image
        /// Version.
        /// </summary>
        [JsonProperty(PropertyName = "excludeFromLatest")]
        public bool? ExcludeFromLatest { get; set; }

        /// <summary>
        /// Gets the timestamp for when the gallery Image Version is published.
        /// </summary>
        [JsonProperty(PropertyName = "publishedDate")]
        public System.DateTime? PublishedDate { get; private set; }

        /// <summary>
        /// Gets or sets the end of life date of the gallery Image Version.
        /// This property can be used for decommissioning purposes. This
        /// property is updatable.
        /// </summary>
        [JsonProperty(PropertyName = "endOfLifeDate")]
        public System.DateTime? EndOfLifeDate { get; set; }

        /// <summary>
        /// Gets or sets specifies the storage account type to be used to store
        /// the image. This property is not updatable. Possible values include:
        /// 'Standard_LRS', 'Standard_ZRS', 'Premium_LRS'
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountType")]
        public StorageAccountType StorageAccountType { get; set; }

    }
}
