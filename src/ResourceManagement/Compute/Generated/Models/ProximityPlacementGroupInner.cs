// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies information about the proximity placement group.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ProximityPlacementGroupInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ProximityPlacementGroupInner
        /// class.
        /// </summary>
        public ProximityPlacementGroupInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProximityPlacementGroupInner
        /// class.
        /// </summary>
        /// <param name="proximityPlacementGroupType">Specifies the type of the
        /// proximity placement group. &lt;br&gt;&lt;br&gt; Possible values
        /// are: &lt;br&gt;&lt;br&gt; **Standard** : Co-locate resources within
        /// an Azure region or Availability Zone. &lt;br&gt;&lt;br&gt;
        /// **Ultra** : For future use. Possible values include: 'Standard',
        /// 'Ultra'</param>
        /// <param name="virtualMachines">A list of references to all virtual
        /// machines in the proximity placement group.</param>
        /// <param name="virtualMachineScaleSets">A list of references to all
        /// virtual machine scale sets in the proximity placement
        /// group.</param>
        /// <param name="availabilitySets">A list of references to all
        /// availability sets in the proximity placement group.</param>
        /// <param name="colocationStatus">Describes colocation status of the
        /// Proximity Placement Group.</param>
        public ProximityPlacementGroupInner(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ProximityPlacementGroupType proximityPlacementGroupType = default(ProximityPlacementGroupType), IList<SubResourceWithColocationStatusInner> virtualMachines = default(IList<SubResourceWithColocationStatusInner>), IList<SubResourceWithColocationStatusInner> virtualMachineScaleSets = default(IList<SubResourceWithColocationStatusInner>), IList<SubResourceWithColocationStatusInner> availabilitySets = default(IList<SubResourceWithColocationStatusInner>), InstanceViewStatus colocationStatus = default(InstanceViewStatus))
            : base(location, id, name, type, tags)
        {
            ProximityPlacementGroupType = proximityPlacementGroupType;
            VirtualMachines = virtualMachines;
            VirtualMachineScaleSets = virtualMachineScaleSets;
            AvailabilitySets = availabilitySets;
            ColocationStatus = colocationStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the type of the proximity placement group.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible values are:
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Standard** : Co-locate
        /// resources within an Azure region or Availability Zone.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Ultra** : For future use.
        /// Possible values include: 'Standard', 'Ultra'
        /// </summary>
        [JsonProperty(PropertyName = "properties.proximityPlacementGroupType")]
        public ProximityPlacementGroupType ProximityPlacementGroupType { get; set; }

        /// <summary>
        /// Gets a list of references to all virtual machines in the proximity
        /// placement group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachines")]
        public IList<SubResourceWithColocationStatusInner> VirtualMachines { get; private set; }

        /// <summary>
        /// Gets a list of references to all virtual machine scale sets in the
        /// proximity placement group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachineScaleSets")]
        public IList<SubResourceWithColocationStatusInner> VirtualMachineScaleSets { get; private set; }

        /// <summary>
        /// Gets a list of references to all availability sets in the proximity
        /// placement group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.availabilitySets")]
        public IList<SubResourceWithColocationStatusInner> AvailabilitySets { get; private set; }

        /// <summary>
        /// Gets or sets describes colocation status of the Proximity Placement
        /// Group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.colocationStatus")]
        public InstanceViewStatus ColocationStatus { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}