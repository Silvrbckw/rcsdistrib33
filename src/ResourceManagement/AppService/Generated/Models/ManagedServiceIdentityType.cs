// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ManagedServiceIdentityType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ManagedServiceIdentityType
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "SystemAssigned")]
        SystemAssigned,
        [EnumMember(Value = "UserAssigned")]
        UserAssigned,
        [EnumMember(Value = "SystemAssigned, UserAssigned")]
        SystemAssignedUserAssigned
    }
    internal static class ManagedServiceIdentityTypeEnumExtension
    {
        internal static string ToSerializedValue(this ManagedServiceIdentityType? value)
        {
            return value == null ? null : ((ManagedServiceIdentityType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ManagedServiceIdentityType value)
        {
            switch( value )
            {
                case ManagedServiceIdentityType.None:
                    return "None";
                case ManagedServiceIdentityType.SystemAssigned:
                    return "SystemAssigned";
                case ManagedServiceIdentityType.UserAssigned:
                    return "UserAssigned";
            }
            return null;
        }

        internal static ManagedServiceIdentityType? ParseManagedServiceIdentityType(this string value)
        {
            switch( value )
            {
                case "None":
                    return ManagedServiceIdentityType.None;
                case "SystemAssigned":
                    return ManagedServiceIdentityType.SystemAssigned;
                case "UserAssigned":
                    return ManagedServiceIdentityType.UserAssigned;
            }
            return null;
        }
    }
}
