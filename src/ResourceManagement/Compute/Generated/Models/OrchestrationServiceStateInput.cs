// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The input for OrchestrationServiceState
    /// </summary>
    public partial class OrchestrationServiceStateInput
    {
        /// <summary>
        /// Initializes a new instance of the OrchestrationServiceStateInput
        /// class.
        /// </summary>
        public OrchestrationServiceStateInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrchestrationServiceStateInput
        /// class.
        /// </summary>
        /// <param name="serviceName">The name of the service. Possible values
        /// include: 'AutomaticRepairs',
        /// 'DummyOrchestrationServiceName'</param>
        /// <param name="action">The action to be performed. Possible values
        /// include: 'Resume', 'Suspend'</param>
        public OrchestrationServiceStateInput(OrchestrationServiceNames serviceName, OrchestrationServiceStateAction action)
        {
            ServiceName = serviceName;
            Action = action;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the service. Possible values include:
        /// 'AutomaticRepairs'
        /// </summary>
        [JsonProperty(PropertyName = "serviceName")]
        public OrchestrationServiceNames ServiceName { get; set; }

        /// <summary>
        /// Gets or sets the action to be performed. Possible values include:
        /// 'Resume', 'Suspend'
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public OrchestrationServiceStateAction Action { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ServiceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServiceName");
            }
            if (Action == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Action");
            }
        }
    }
}
