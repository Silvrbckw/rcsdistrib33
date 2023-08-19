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

    /// <summary>
    /// Active Directory service principal information.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ServicePrincipal")]
    public partial class ServicePrincipalInner : DirectoryObject
    {
        /// <summary>
        /// Initializes a new instance of the ServicePrincipalInner class.
        /// </summary>
        public ServicePrincipalInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServicePrincipalInner class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="objectId">The object ID.</param>
        /// <param name="deletionTimestamp">The time at which the directory
        /// object was deleted.</param>
        /// <param name="accountEnabled">whether or not the service principal
        /// account is enabled</param>
        /// <param name="alternativeNames">alternative names</param>
        /// <param name="appDisplayName">The display name exposed by the
        /// associated application.</param>
        /// <param name="appId">The application ID.</param>
        /// <param name="appRoleAssignmentRequired">Specifies whether an
        /// AppRoleAssignment to a user or group is required before Azure AD
        /// will issue a user or access token to the application.</param>
        /// <param name="appRoles">The collection of application roles that an
        /// application may declare. These roles can be assigned to users,
        /// groups or service principals.</param>
        /// <param name="displayName">The display name of the service
        /// principal.</param>
        /// <param name="errorUrl">A URL provided by the author of the
        /// associated application to report errors when using the
        /// application.</param>
        /// <param name="homepage">The URL to the homepage of the associated
        /// application.</param>
        /// <param name="keyCredentials">The collection of key credentials
        /// associated with the service principal.</param>
        /// <param name="logoutUrl">A URL provided by the author of the
        /// associated application to logout</param>
        /// <param name="oauth2Permissions">The OAuth 2.0 permissions exposed
        /// by the associated application.</param>
        /// <param name="passwordCredentials">The collection of password
        /// credentials associated with the service principal.</param>
        /// <param name="preferredTokenSigningKeyThumbprint">The thumbprint of
        /// preferred certificate to sign the token</param>
        /// <param name="publisherName">The publisher's name of the associated
        /// application</param>
        /// <param name="replyUrls">The URLs that user tokens are sent to for
        /// sign in with the associated application.  The redirect URIs that
        /// the oAuth 2.0 authorization code and access tokens are sent to for
        /// the associated application.</param>
        /// <param name="samlMetadataUrl">The URL to the SAML metadata of the
        /// associated application</param>
        /// <param name="servicePrincipalNames">A collection of service
        /// principal names.</param>
        /// <param name="servicePrincipalType">the type of the service
        /// principal</param>
        /// <param name="tags">Optional list of tags that you can apply to your
        /// service principals. Not nullable.</param>
        public ServicePrincipalInner(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string objectId = default(string), System.DateTime? deletionTimestamp = default(System.DateTime?), bool? accountEnabled = default(bool?), IList<string> alternativeNames = default(IList<string>), string appDisplayName = default(string), string appId = default(string), string appOwnerTenantId = default(string), bool? appRoleAssignmentRequired = default(bool?), IList<AppRole> appRoles = default(IList<AppRole>), string displayName = default(string), string errorUrl = default(string), string homepage = default(string), IList<KeyCredential> keyCredentials = default(IList<KeyCredential>), string logoutUrl = default(string), IList<OAuth2Permission> oauth2Permissions = default(IList<OAuth2Permission>), IList<PasswordCredential> passwordCredentials = default(IList<PasswordCredential>), string preferredTokenSigningKeyThumbprint = default(string), string publisherName = default(string), IList<string> replyUrls = default(IList<string>), string samlMetadataUrl = default(string), IList<string> servicePrincipalNames = default(IList<string>), string servicePrincipalType = default(string), IList<string> tags = default(IList<string>))
            : base(additionalProperties, objectId, deletionTimestamp)
        {
            AccountEnabled = accountEnabled;
            AlternativeNames = alternativeNames;
            AppDisplayName = appDisplayName;
            AppId = appId;
            AppOwnerTenantId = appOwnerTenantId;
            AppRoleAssignmentRequired = appRoleAssignmentRequired;
            AppRoles = appRoles;
            DisplayName = displayName;
            ErrorUrl = errorUrl;
            Homepage = homepage;
            KeyCredentials = keyCredentials;
            LogoutUrl = logoutUrl;
            Oauth2Permissions = oauth2Permissions;
            PasswordCredentials = passwordCredentials;
            PreferredTokenSigningKeyThumbprint = preferredTokenSigningKeyThumbprint;
            PublisherName = publisherName;
            ReplyUrls = replyUrls;
            SamlMetadataUrl = samlMetadataUrl;
            ServicePrincipalNames = servicePrincipalNames;
            ServicePrincipalType = servicePrincipalType;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether or not the service principal account is
        /// enabled
        /// </summary>
        [JsonProperty(PropertyName = "accountEnabled")]
        public bool? AccountEnabled { get; set; }

        /// <summary>
        /// Gets or sets alternative names
        /// </summary>
        [JsonProperty(PropertyName = "alternativeNames")]
        public IList<string> AlternativeNames { get; set; }

        /// <summary>
        /// Gets the display name exposed by the associated application.
        /// </summary>
        [JsonProperty(PropertyName = "appDisplayName")]
        public string AppDisplayName { get; private set; }

        /// <summary>
        /// Gets or sets the application ID.
        /// </summary>
        [JsonProperty(PropertyName = "appId")]
        public string AppId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appOwnerTenantId")]
        public string AppOwnerTenantId { get; private set; }

        /// <summary>
        /// Gets or sets specifies whether an AppRoleAssignment to a user or
        /// group is required before Azure AD will issue a user or access token
        /// to the application.
        /// </summary>
        [JsonProperty(PropertyName = "appRoleAssignmentRequired")]
        public bool? AppRoleAssignmentRequired { get; set; }

        /// <summary>
        /// Gets or sets the collection of application roles that an
        /// application may declare. These roles can be assigned to users,
        /// groups or service principals.
        /// </summary>
        [JsonProperty(PropertyName = "appRoles")]
        public IList<AppRole> AppRoles { get; set; }

        /// <summary>
        /// Gets or sets the display name of the service principal.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets a URL provided by the author of the associated
        /// application to report errors when using the application.
        /// </summary>
        [JsonProperty(PropertyName = "errorUrl")]
        public string ErrorUrl { get; set; }

        /// <summary>
        /// Gets or sets the URL to the homepage of the associated application.
        /// </summary>
        [JsonProperty(PropertyName = "homepage")]
        public string Homepage { get; set; }

        /// <summary>
        /// Gets or sets the collection of key credentials associated with the
        /// service principal.
        /// </summary>
        [JsonProperty(PropertyName = "keyCredentials")]
        public IList<KeyCredential> KeyCredentials { get; set; }

        /// <summary>
        /// Gets or sets a URL provided by the author of the associated
        /// application to logout
        /// </summary>
        [JsonProperty(PropertyName = "logoutUrl")]
        public string LogoutUrl { get; set; }

        /// <summary>
        /// Gets the OAuth 2.0 permissions exposed by the associated
        /// application.
        /// </summary>
        [JsonProperty(PropertyName = "oauth2Permissions")]
        public IList<OAuth2Permission> Oauth2Permissions { get; private set; }

        /// <summary>
        /// Gets or sets the collection of password credentials associated with
        /// the service principal.
        /// </summary>
        [JsonProperty(PropertyName = "passwordCredentials")]
        public IList<PasswordCredential> PasswordCredentials { get; set; }

        /// <summary>
        /// Gets or sets the thumbprint of preferred certificate to sign the
        /// token
        /// </summary>
        [JsonProperty(PropertyName = "preferredTokenSigningKeyThumbprint")]
        public string PreferredTokenSigningKeyThumbprint { get; set; }

        /// <summary>
        /// Gets or sets the publisher's name of the associated application
        /// </summary>
        [JsonProperty(PropertyName = "publisherName")]
        public string PublisherName { get; set; }

        /// <summary>
        /// Gets or sets the URLs that user tokens are sent to for sign in with
        /// the associated application.  The redirect URIs that the oAuth 2.0
        /// authorization code and access tokens are sent to for the associated
        /// application.
        /// </summary>
        [JsonProperty(PropertyName = "replyUrls")]
        public IList<string> ReplyUrls { get; set; }

        /// <summary>
        /// Gets or sets the URL to the SAML metadata of the associated
        /// application
        /// </summary>
        [JsonProperty(PropertyName = "samlMetadataUrl")]
        public string SamlMetadataUrl { get; set; }

        /// <summary>
        /// Gets or sets a collection of service principal names.
        /// </summary>
        [JsonProperty(PropertyName = "servicePrincipalNames")]
        public IList<string> ServicePrincipalNames { get; set; }

        /// <summary>
        /// Gets or sets the type of the service principal
        /// </summary>
        [JsonProperty(PropertyName = "servicePrincipalType")]
        public string ServicePrincipalType { get; set; }

        /// <summary>
        /// Gets or sets optional list of tags that you can apply to your
        /// service principals. Not nullable.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }

    }
}
