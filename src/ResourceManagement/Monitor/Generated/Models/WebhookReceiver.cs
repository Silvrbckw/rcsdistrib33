// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A webhook receiver.
    /// </summary>
    public partial class WebhookReceiver
    {
        /// <summary>
        /// Initializes a new instance of the WebhookReceiver class.
        /// </summary>
        public WebhookReceiver()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebhookReceiver class.
        /// </summary>
        /// <param name="name">The name of the webhook receiver. Names must be
        /// unique across all receivers within an action group.</param>
        /// <param name="serviceUri">The URI where webhooks should be
        /// sent.</param>
        /// <param name="useCommonAlertSchema">Indicates whether to use common
        /// alert schema.</param>
        /// <param name="useAadAuth">Indicates whether or not use AAD
        /// authentication.</param>
        /// <param name="objectId">Indicates the webhook app object Id for aad
        /// auth.</param>
        /// <param name="identifierUri">Indicates the identifier uri for aad
        /// auth.</param>
        /// <param name="tenantId">Indicates the tenant id for aad
        /// auth.</param>
        public WebhookReceiver(string name, string serviceUri, bool useCommonAlertSchema, bool? useAadAuth = default(bool?), string objectId = default(string), string identifierUri = default(string), string tenantId = default(string))
        {
            Name = name;
            ServiceUri = serviceUri;
            UseCommonAlertSchema = useCommonAlertSchema;
            UseAadAuth = useAadAuth;
            ObjectId = objectId;
            IdentifierUri = identifierUri;
            TenantId = tenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the webhook receiver. Names must be unique
        /// across all receivers within an action group.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the URI where webhooks should be sent.
        /// </summary>
        [JsonProperty(PropertyName = "serviceUri")]
        public string ServiceUri { get; set; }

        /// <summary>
        /// Gets or sets indicates whether to use common alert schema.
        /// </summary>
        [JsonProperty(PropertyName = "useCommonAlertSchema")]
        public bool UseCommonAlertSchema { get; set; }

        /// <summary>
        /// Gets or sets indicates whether or not use AAD authentication.
        /// </summary>
        [JsonProperty(PropertyName = "useAadAuth")]
        public bool? UseAadAuth { get; set; }

        /// <summary>
        /// Gets or sets indicates the webhook app object Id for aad auth.
        /// </summary>
        [JsonProperty(PropertyName = "objectId")]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or sets indicates the identifier uri for aad auth.
        /// </summary>
        [JsonProperty(PropertyName = "identifierUri")]
        public string IdentifierUri { get; set; }

        /// <summary>
        /// Gets or sets indicates the tenant id for aad auth.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (ServiceUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServiceUri");
            }
        }
    }
}
