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
    /// Request parameters for creating a new group.
    /// </summary>
    public partial class GroupCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the GroupCreateParameters class.
        /// </summary>
        public GroupCreateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupCreateParameters class.
        /// </summary>
        /// <param name="displayName">Group display name</param>
        /// <param name="mailNickname">Mail nickname</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        public GroupCreateParameters(string displayName, string mailNickname, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>))
        {
            AdditionalProperties = additionalProperties;
            DisplayName = displayName;
            MailNickname = mailNickname;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for GroupCreateParameters class.
        /// </summary>
        static GroupCreateParameters()
        {
            MailEnabled = false;
            SecurityEnabled = true;
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
        /// Gets or sets group display name
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets mail nickname
        /// </summary>
        [JsonProperty(PropertyName = "mailNickname")]
        public string MailNickname { get; set; }

        /// <summary>
        /// Whether the group is mail-enabled. Must be false. This is because
        /// only pure security groups can be created using the Graph API.
        /// </summary>
        [JsonProperty(PropertyName = "mailEnabled")]
        public static bool MailEnabled { get; private set; }

        /// <summary>
        /// Whether the group is a security group. Must be true. This is
        /// because only pure security groups can be created using the Graph
        /// API.
        /// </summary>
        [JsonProperty(PropertyName = "securityEnabled")]
        public static bool SecurityEnabled { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (MailNickname == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MailNickname");
            }
        }
    }
}
