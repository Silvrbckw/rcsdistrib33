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
    /// Defines values for BackupRestoreOperationType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BackupRestoreOperationType
    {
        [EnumMember(Value = "Default")]
        Default,
        [EnumMember(Value = "Clone")]
        Clone,
        [EnumMember(Value = "Relocation")]
        Relocation,
        [EnumMember(Value = "Snapshot")]
        Snapshot,
        [EnumMember(Value = "CloudFS")]
        CloudFS
    }
    internal static class BackupRestoreOperationTypeEnumExtension
    {
        internal static string ToSerializedValue(this BackupRestoreOperationType? value)
        {
            return value == null ? null : ((BackupRestoreOperationType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this BackupRestoreOperationType value)
        {
            switch( value )
            {
                case BackupRestoreOperationType.Default:
                    return "Default";
                case BackupRestoreOperationType.Clone:
                    return "Clone";
                case BackupRestoreOperationType.Relocation:
                    return "Relocation";
                case BackupRestoreOperationType.Snapshot:
                    return "Snapshot";
                case BackupRestoreOperationType.CloudFS:
                    return "CloudFS";
            }
            return null;
        }

        internal static BackupRestoreOperationType? ParseBackupRestoreOperationType(this string value)
        {
            switch( value )
            {
                case "Default":
                    return BackupRestoreOperationType.Default;
                case "Clone":
                    return BackupRestoreOperationType.Clone;
                case "Relocation":
                    return BackupRestoreOperationType.Relocation;
                case "Snapshot":
                    return BackupRestoreOperationType.Snapshot;
                case "CloudFS":
                    return BackupRestoreOperationType.CloudFS;
            }
            return null;
        }
    }
}