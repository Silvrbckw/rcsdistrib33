// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Newtonsoft.Json;

namespace Microsoft.Azure.Management.ContainerInstance.Fluent.Models
{

    /// <summary>
    /// Defines values for OperatingSystemTypes.
    /// </summary>
    [JsonConverter(typeof(ExpandableStringEnumConverter<OperatingSystemTypes>))]
    public class OperatingSystemTypes : ExpandableStringEnum<OperatingSystemTypes>
    {
        public static readonly OperatingSystemTypes Windows = Parse("Windows");
        public static readonly OperatingSystemTypes Linux = Parse("Linux");
    }
}
