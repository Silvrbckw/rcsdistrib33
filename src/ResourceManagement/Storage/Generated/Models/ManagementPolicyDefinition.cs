// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An object that defines the Lifecycle rule. Each definition is made up
    /// with a filters set and an actions set.
    /// </summary>
    public partial class ManagementPolicyDefinition
    {
        /// <summary>
        /// Initializes a new instance of the ManagementPolicyDefinition class.
        /// </summary>
        public ManagementPolicyDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagementPolicyDefinition class.
        /// </summary>
        /// <param name="actions">An object that defines the action
        /// set.</param>
        /// <param name="filters">An object that defines the filter
        /// set.</param>
        public ManagementPolicyDefinition(ManagementPolicyAction actions, ManagementPolicyFilter filters = default(ManagementPolicyFilter))
        {
            Actions = actions;
            Filters = filters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an object that defines the action set.
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public ManagementPolicyAction Actions { get; set; }

        /// <summary>
        /// Gets or sets an object that defines the filter set.
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public ManagementPolicyFilter Filters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Actions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Actions");
            }
            if (Actions != null)
            {
                Actions.Validate();
            }
            if (Filters != null)
            {
                Filters.Validate();
            }
        }
    }
}
