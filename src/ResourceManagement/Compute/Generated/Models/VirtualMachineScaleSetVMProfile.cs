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
    /// Describes a virtual machine scale set virtual machine profile.
    /// </summary>
    public partial class VirtualMachineScaleSetVMProfile
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetVMProfile
        /// class.
        /// </summary>
        public VirtualMachineScaleSetVMProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetVMProfile
        /// class.
        /// </summary>
        /// <param name="osProfile">Specifies the operating system settings for
        /// the virtual machines in the scale set.</param>
        /// <param name="storageProfile">Specifies the storage settings for the
        /// virtual machine disks.</param>
        /// <param name="networkProfile">Specifies properties of the network
        /// interfaces of the virtual machines in the scale set.</param>
        /// <param name="securityProfile">Specifies the Security related
        /// profile settings for the virtual machines in the scale set.</param>
        /// <param name="diagnosticsProfile">Specifies the boot diagnostic
        /// settings state. &lt;br&gt;&lt;br&gt;Minimum api-version:
        /// 2015-06-15.</param>
        /// <param name="extensionProfile">Specifies a collection of settings
        /// for extensions installed on virtual machines in the scale
        /// set.</param>
        /// <param name="licenseType">Specifies that the image or disk that is
        /// being used was licensed on-premises. This element is only used for
        /// images that contain the Windows Server operating system.
        /// &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt;
        /// Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server
        /// &lt;br&gt;&lt;br&gt; If this element is included in a request for
        /// an update, the value must match the initial value. This value
        /// cannot be updated. &lt;br&gt;&lt;br&gt; For more information, see
        /// [Azure Hybrid Use Benefit for Windows
        /// Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json)
        /// &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15</param>
        /// <param name="priority">Specifies the priority for the virtual
        /// machines in the scale set. &lt;br&gt;&lt;br&gt;Minimum api-version:
        /// 2017-10-30-preview. Possible values include: 'Regular', 'Low',
        /// 'Spot'</param>
        /// <param name="evictionPolicy">Specifies the eviction policy for the
        /// Azure Spot virtual machine and Azure Spot scale set.
        /// &lt;br&gt;&lt;br&gt;For Azure Spot virtual machines, both
        /// 'Deallocate' and 'Delete' are supported and the minimum api-version
        /// is 2019-03-01. &lt;br&gt;&lt;br&gt;For Azure Spot scale sets, both
        /// 'Deallocate' and 'Delete' are supported and the minimum api-version
        /// is 2017-10-30-preview. Possible values include: 'Deallocate',
        /// 'Delete'</param>
        /// <param name="billingProfile">Specifies the billing related details
        /// of a Azure Spot VMSS. &lt;br&gt;&lt;br&gt;Minimum api-version:
        /// 2019-03-01.</param>
        /// <param name="scheduledEventsProfile">Specifies Scheduled Event
        /// related configurations.</param>
        public VirtualMachineScaleSetVMProfile(VirtualMachineScaleSetOSProfile osProfile = default(VirtualMachineScaleSetOSProfile), VirtualMachineScaleSetStorageProfile storageProfile = default(VirtualMachineScaleSetStorageProfile), VirtualMachineScaleSetNetworkProfile networkProfile = default(VirtualMachineScaleSetNetworkProfile), SecurityProfile securityProfile = default(SecurityProfile), DiagnosticsProfile diagnosticsProfile = default(DiagnosticsProfile), VirtualMachineScaleSetExtensionProfile extensionProfile = default(VirtualMachineScaleSetExtensionProfile), string licenseType = default(string), VirtualMachinePriorityTypes priority = default(VirtualMachinePriorityTypes), VirtualMachineEvictionPolicyTypes evictionPolicy = default(VirtualMachineEvictionPolicyTypes), BillingProfile billingProfile = default(BillingProfile), ScheduledEventsProfile scheduledEventsProfile = default(ScheduledEventsProfile))
        {
            OsProfile = osProfile;
            StorageProfile = storageProfile;
            NetworkProfile = networkProfile;
            SecurityProfile = securityProfile;
            DiagnosticsProfile = diagnosticsProfile;
            ExtensionProfile = extensionProfile;
            LicenseType = licenseType;
            Priority = priority;
            EvictionPolicy = evictionPolicy;
            BillingProfile = billingProfile;
            ScheduledEventsProfile = scheduledEventsProfile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the operating system settings for the
        /// virtual machines in the scale set.
        /// </summary>
        [JsonProperty(PropertyName = "osProfile")]
        public VirtualMachineScaleSetOSProfile OsProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies the storage settings for the virtual machine
        /// disks.
        /// </summary>
        [JsonProperty(PropertyName = "storageProfile")]
        public VirtualMachineScaleSetStorageProfile StorageProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies properties of the network interfaces of the
        /// virtual machines in the scale set.
        /// </summary>
        [JsonProperty(PropertyName = "networkProfile")]
        public VirtualMachineScaleSetNetworkProfile NetworkProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies the Security related profile settings for
        /// the virtual machines in the scale set.
        /// </summary>
        [JsonProperty(PropertyName = "securityProfile")]
        public SecurityProfile SecurityProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies the boot diagnostic settings state.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api-version:
        /// 2015-06-15.
        /// </summary>
        [JsonProperty(PropertyName = "diagnosticsProfile")]
        public DiagnosticsProfile DiagnosticsProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies a collection of settings for extensions
        /// installed on virtual machines in the scale set.
        /// </summary>
        [JsonProperty(PropertyName = "extensionProfile")]
        public VirtualMachineScaleSetExtensionProfile ExtensionProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies that the image or disk that is being used
        /// was licensed on-premises. This element is only used for images that
        /// contain the Windows Server operating system.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible values are:
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Windows_Client
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Windows_Server
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; If this element is included in
        /// a request for an update, the value must match the initial value.
        /// This value cannot be updated. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;
        /// For more information, see [Azure Hybrid Use Benefit for Windows
        /// Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json)
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Minimum api-version:
        /// 2015-06-15
        /// </summary>
        [JsonProperty(PropertyName = "licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets or sets specifies the priority for the virtual machines in the
        /// scale set. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api-version:
        /// 2017-10-30-preview. Possible values include: 'Regular', 'Low',
        /// 'Spot'
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public VirtualMachinePriorityTypes Priority { get; set; }

        /// <summary>
        /// Gets or sets specifies the eviction policy for the Azure Spot
        /// virtual machine and Azure Spot scale set.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;For Azure Spot virtual
        /// machines, both 'Deallocate' and 'Delete' are supported and the
        /// minimum api-version is 2019-03-01.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;For Azure Spot scale sets, both
        /// 'Deallocate' and 'Delete' are supported and the minimum api-version
        /// is 2017-10-30-preview. Possible values include: 'Deallocate',
        /// 'Delete'
        /// </summary>
        [JsonProperty(PropertyName = "evictionPolicy")]
        public VirtualMachineEvictionPolicyTypes EvictionPolicy { get; set; }

        /// <summary>
        /// Gets or sets specifies the billing related details of a Azure Spot
        /// VMSS. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api-version:
        /// 2019-03-01.
        /// </summary>
        [JsonProperty(PropertyName = "billingProfile")]
        public BillingProfile BillingProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies Scheduled Event related configurations.
        /// </summary>
        [JsonProperty(PropertyName = "scheduledEventsProfile")]
        public ScheduledEventsProfile ScheduledEventsProfile { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageProfile != null)
            {
                StorageProfile.Validate();
            }
        }
    }
}
