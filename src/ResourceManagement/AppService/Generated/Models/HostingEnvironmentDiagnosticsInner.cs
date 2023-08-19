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
    using System.Linq;

    /// <summary>
    /// Diagnostics for an App Service Environment.
    /// </summary>
    public partial class HostingEnvironmentDiagnosticsInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HostingEnvironmentDiagnosticsInner class.
        /// </summary>
        public HostingEnvironmentDiagnosticsInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// HostingEnvironmentDiagnosticsInner class.
        /// </summary>
        /// <param name="name">Name/identifier of the diagnostics.</param>
        /// <param name="diagnosticsOutput">Diagnostics output.</param>
        public HostingEnvironmentDiagnosticsInner(string name = default(string), string diagnosticsOutput = default(string))
        {
            Name = name;
            DiagnosticsOutput = diagnosticsOutput;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name/identifier of the diagnostics.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets diagnostics output.
        /// </summary>
        [JsonProperty(PropertyName = "diagnosticsOutput")]
        public string DiagnosticsOutput { get; set; }

    }
}