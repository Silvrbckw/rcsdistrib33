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
    /// Defines values for ManagedPipelineMode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ManagedPipelineMode
    {
        [EnumMember(Value = "Integrated")]
        Integrated,
        [EnumMember(Value = "Classic")]
        Classic
    }
    internal static class ManagedPipelineModeEnumExtension
    {
        internal static string ToSerializedValue(this ManagedPipelineMode? value)
        {
            return value == null ? null : ((ManagedPipelineMode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ManagedPipelineMode value)
        {
            switch( value )
            {
                case ManagedPipelineMode.Integrated:
                    return "Integrated";
                case ManagedPipelineMode.Classic:
                    return "Classic";
            }
            return null;
        }

        internal static ManagedPipelineMode? ParseManagedPipelineMode(this string value)
        {
            switch( value )
            {
                case "Integrated":
                    return ManagedPipelineMode.Integrated;
                case "Classic":
                    return ManagedPipelineMode.Classic;
            }
            return null;
        }
    }
}
