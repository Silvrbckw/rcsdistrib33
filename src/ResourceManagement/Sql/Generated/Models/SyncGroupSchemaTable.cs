// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of table in sync group schema.
    /// </summary>
    public partial class SyncGroupSchemaTable
    {
        /// <summary>
        /// Initializes a new instance of the SyncGroupSchemaTable class.
        /// </summary>
        public SyncGroupSchemaTable()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SyncGroupSchemaTable class.
        /// </summary>
        /// <param name="columns">List of columns in sync group schema.</param>
        /// <param name="quotedName">Quoted name of sync group schema
        /// table.</param>
        public SyncGroupSchemaTable(IList<SyncGroupSchemaTableColumn> columns = default(IList<SyncGroupSchemaTableColumn>), string quotedName = default(string))
        {
            Columns = columns;
            QuotedName = quotedName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of columns in sync group schema.
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public IList<SyncGroupSchemaTableColumn> Columns { get; set; }

        /// <summary>
        /// Gets or sets quoted name of sync group schema table.
        /// </summary>
        [JsonProperty(PropertyName = "quotedName")]
        public string QuotedName { get; set; }

    }
}
