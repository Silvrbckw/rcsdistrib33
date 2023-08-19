// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for SnapshotStorageAccountTypes.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<SnapshotStorageAccountTypes>))]
    public class SnapshotStorageAccountTypes : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<SnapshotStorageAccountTypes>
    {
        public static readonly SnapshotStorageAccountTypes StandardLRS = Parse("Standard_LRS");
        public static readonly SnapshotStorageAccountTypes PremiumLRS = Parse("Premium_LRS");
        public static readonly SnapshotStorageAccountTypes StandardZRS = Parse("Standard_ZRS");
    }
}
