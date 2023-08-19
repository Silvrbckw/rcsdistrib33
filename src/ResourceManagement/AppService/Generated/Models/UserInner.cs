// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// User credentials used for publishing activity.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class UserInner : ProxyOnlyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the UserInner class.
        /// </summary>
        public UserInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserInner class.
        /// </summary>
        /// <param name="publishingUserName">Username used for
        /// publishing.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="publishingPassword">Password used for
        /// publishing.</param>
        /// <param name="publishingPasswordHash">Password hash used for
        /// publishing.</param>
        /// <param name="publishingPasswordHashSalt">Password hash salt used
        /// for publishing.</param>
        /// <param name="scmUri">Url of SCM site.</param>
        public UserInner(string publishingUserName, string id = default(string), string name = default(string), string type = default(string), string kind = default(string), string publishingPassword = default(string), string publishingPasswordHash = default(string), string publishingPasswordHashSalt = default(string), string scmUri = default(string))
            : base(id, name, type, kind)
        {
            PublishingUserName = publishingUserName;
            PublishingPassword = publishingPassword;
            PublishingPasswordHash = publishingPasswordHash;
            PublishingPasswordHashSalt = publishingPasswordHashSalt;
            ScmUri = scmUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets username used for publishing.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingUserName")]
        public string PublishingUserName { get; set; }

        /// <summary>
        /// Gets or sets password used for publishing.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingPassword")]
        public string PublishingPassword { get; set; }

        /// <summary>
        /// Gets or sets password hash used for publishing.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingPasswordHash")]
        public string PublishingPasswordHash { get; set; }

        /// <summary>
        /// Gets or sets password hash salt used for publishing.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingPasswordHashSalt")]
        public string PublishingPasswordHashSalt { get; set; }

        /// <summary>
        /// Gets or sets url of SCM site.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scmUri")]
        public string ScmUri { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PublishingUserName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PublishingUserName");
            }
        }
    }
}
