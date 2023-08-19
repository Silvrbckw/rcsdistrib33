// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies the set of OAuth 2.0 permission scopes and app roles under
    /// the specified resource that an application requires access to. The
    /// specified OAuth 2.0 permission scopes may be requested by client
    /// applications (through the requiredResourceAccess collection) when
    /// calling a resource application. The requiredResourceAccess property of
    /// the Application entity is a collection of RequiredResourceAccess.
    /// </summary>
    public partial class RequiredResourceAccess
    {
        /// <summary>
        /// Initializes a new instance of the RequiredResourceAccess class.
        /// </summary>
        public RequiredResourceAccess()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RequiredResourceAccess class.
        /// </summary>
        /// <param name="resourceAccess">The list of OAuth2.0 permission scopes
        /// and app roles that the application requires from the specified
        /// resource.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="resourceAppId">The unique identifier for the resource
        /// that the application requires access to. This should be equal to
        /// the appId declared on the target resource application.</param>
        public RequiredResourceAccess(IList<ResourceAccess> resourceAccess, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string resourceAppId = default(string))
        {
            AdditionalProperties = additionalProperties;
            ResourceAccess = resourceAccess;
            ResourceAppId = resourceAppId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets the list of OAuth2.0 permission scopes and app roles
        /// that the application requires from the specified resource.
        /// </summary>
        [JsonProperty(PropertyName = "resourceAccess")]
        public IList<ResourceAccess> ResourceAccess { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the resource that the
        /// application requires access to. This should be equal to the appId
        /// declared on the target resource application.
        /// </summary>
        [JsonProperty(PropertyName = "resourceAppId")]
        public string ResourceAppId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ResourceAccess == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceAccess");
            }
            if (ResourceAccess != null)
            {
                foreach (var element in ResourceAccess)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
