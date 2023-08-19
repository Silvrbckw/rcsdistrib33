// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class UserBase
    {
        /// <summary>
        /// Initializes a new instance of the UserBase class.
        /// </summary>
        public UserBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserBase class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="immutableId">This must be specified if you are using a
        /// federated domain for the user's userPrincipalName (UPN) property
        /// when creating a new user account. It is used to associate an
        /// on-premises Active Directory user account with their Azure AD user
        /// object.</param>
        /// <param name="usageLocation">A two letter country code (ISO standard
        /// 3166). Required for users that will be assigned licenses due to
        /// legal requirement to check for availability of services in
        /// countries. Examples include: "US", "JP", and "GB".</param>
        /// <param name="givenName">The given name for the user.</param>
        /// <param name="surname">The user's surname (family name or last
        /// name).</param>
        /// <param name="userType">A string value that can be used to classify
        /// user types in your directory, such as 'Member' and 'Guest'.
        /// Possible values include: 'Member', 'Guest'</param>
        public UserBase(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string immutableId = default(string), string usageLocation = default(string), string givenName = default(string), string surname = default(string), UserType userType = default(UserType))
        {
            AdditionalProperties = additionalProperties;
            ImmutableId = immutableId;
            UsageLocation = usageLocation;
            GivenName = givenName;
            Surname = surname;
            UserType = userType;
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
        /// Gets or sets this must be specified if you are using a federated
        /// domain for the user's userPrincipalName (UPN) property when
        /// creating a new user account. It is used to associate an on-premises
        /// Active Directory user account with their Azure AD user object.
        /// </summary>
        [JsonProperty(PropertyName = "immutableId")]
        public string ImmutableId { get; set; }

        /// <summary>
        /// Gets or sets a two letter country code (ISO standard 3166).
        /// Required for users that will be assigned licenses due to legal
        /// requirement to check for availability of services in countries.
        /// Examples include: "US", "JP", and "GB".
        /// </summary>
        [JsonProperty(PropertyName = "usageLocation")]
        public string UsageLocation { get; set; }

        /// <summary>
        /// Gets or sets the given name for the user.
        /// </summary>
        [JsonProperty(PropertyName = "givenName")]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or sets the user's surname (family name or last name).
        /// </summary>
        [JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets a string value that can be used to classify user types
        /// in your directory, such as 'Member' and 'Guest'. Possible values
        /// include: 'Member', 'Guest'
        /// </summary>
        [JsonProperty(PropertyName = "userType")]
        public UserType UserType { get; set; }

    }
}
