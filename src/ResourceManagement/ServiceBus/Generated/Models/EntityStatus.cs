// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServiceBus.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for EntityStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityStatus
    {
        [EnumMember(Value = "Active")]
        Active,
        [EnumMember(Value = "Creating")]
        Creating,
        [EnumMember(Value = "Deleting")]
        Deleting,
        [EnumMember(Value = "Disabled")]
        Disabled,
        [EnumMember(Value = "ReceiveDisabled")]
        ReceiveDisabled,
        [EnumMember(Value = "Renaming")]
        Renaming,
        [EnumMember(Value = "Restoring")]
        Restoring,
        [EnumMember(Value = "SendDisabled")]
        SendDisabled,
        [EnumMember(Value = "Unknown")]
        Unknown
    }
}
