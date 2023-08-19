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
    /// Defines values for DnsVerificationTestResult.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DnsVerificationTestResult
    {
        [EnumMember(Value = "Passed")]
        Passed,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Skipped")]
        Skipped
    }
    internal static class DnsVerificationTestResultEnumExtension
    {
        internal static string ToSerializedValue(this DnsVerificationTestResult? value)
        {
            return value == null ? null : ((DnsVerificationTestResult)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DnsVerificationTestResult value)
        {
            switch( value )
            {
                case DnsVerificationTestResult.Passed:
                    return "Passed";
                case DnsVerificationTestResult.Failed:
                    return "Failed";
                case DnsVerificationTestResult.Skipped:
                    return "Skipped";
            }
            return null;
        }

        internal static DnsVerificationTestResult? ParseDnsVerificationTestResult(this string value)
        {
            switch( value )
            {
                case "Passed":
                    return DnsVerificationTestResult.Passed;
                case "Failed":
                    return DnsVerificationTestResult.Failed;
                case "Skipped":
                    return DnsVerificationTestResult.Skipped;
            }
            return null;
        }
    }
}
