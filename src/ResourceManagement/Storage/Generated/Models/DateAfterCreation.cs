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
    /// Object to define the number of days after creation.
    /// </summary>
    public partial class DateAfterCreation
    {
        /// <summary>
        /// Initializes a new instance of the DateAfterCreation class.
        /// </summary>
        public DateAfterCreation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DateAfterCreation class.
        /// </summary>
        /// <param name="daysAfterCreationGreaterThan">Integer value indicating
        /// the age in days after creation</param>
        public DateAfterCreation(int daysAfterCreationGreaterThan)
        {
            DaysAfterCreationGreaterThan = daysAfterCreationGreaterThan;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets integer value indicating the age in days after
        /// creation
        /// </summary>
        [JsonProperty(PropertyName = "daysAfterCreationGreaterThan")]
        public int DaysAfterCreationGreaterThan { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DaysAfterCreationGreaterThan < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "DaysAfterCreationGreaterThan", 0);
            }
        }
    }
}
