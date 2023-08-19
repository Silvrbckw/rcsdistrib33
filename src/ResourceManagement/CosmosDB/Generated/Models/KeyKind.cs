// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for KeyKind.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<KeyKind>))]
    public class KeyKind : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<KeyKind>
    {
        public static readonly KeyKind Primary = Parse("primary");
        public static readonly KeyKind Secondary = Parse("secondary");
        public static readonly KeyKind PrimaryReadonly = Parse("primaryReadonly");
        public static readonly KeyKind SecondaryReadonly = Parse("secondaryReadonly");
    }
}