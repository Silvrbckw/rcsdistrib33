// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AutomaticTuningServerMode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AutomaticTuningServerMode
    {
        [EnumMember(Value = "Custom")]
        Custom,
        [EnumMember(Value = "Auto")]
        Auto,
        [EnumMember(Value = "Unspecified")]
        Unspecified
    }
    internal static class AutomaticTuningServerModeEnumExtension
    {
        internal static string ToSerializedValue(this AutomaticTuningServerMode? value)
        {
            return value == null ? null : ((AutomaticTuningServerMode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AutomaticTuningServerMode value)
        {
            switch( value )
            {
                case AutomaticTuningServerMode.Custom:
                    return "Custom";
                case AutomaticTuningServerMode.Auto:
                    return "Auto";
                case AutomaticTuningServerMode.Unspecified:
                    return "Unspecified";
            }
            return null;
        }

        internal static AutomaticTuningServerMode? ParseAutomaticTuningServerMode(this string value)
        {
            switch( value )
            {
                case "Custom":
                    return AutomaticTuningServerMode.Custom;
                case "Auto":
                    return AutomaticTuningServerMode.Auto;
                case "Unspecified":
                    return AutomaticTuningServerMode.Unspecified;
            }
            return null;
        }
    }
}
