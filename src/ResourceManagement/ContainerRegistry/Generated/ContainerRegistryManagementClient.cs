// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    public partial class ContainerRegistryManagementClient : FluentServiceClientBase<ContainerRegistryManagementClient>, IContainerRegistryManagementClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        //public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// The Microsoft Azure subscription ID.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IRegistriesOperations.
        /// </summary>
        public virtual IRegistriesOperations Registries { get; private set; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        public virtual IOperations Operations { get; private set; }

        /// <summary>
        /// Gets the IReplicationsOperations.
        /// </summary>
        public virtual IReplicationsOperations Replications { get; private set; }

        /// <summary>
        /// Gets the IWebhooksOperations.
        /// </summary>
        public virtual IWebhooksOperations Webhooks { get; private set; }

        /// <summary>
        /// Gets the IRunsOperations.
        /// </summary>
        public virtual IRunsOperations Runs { get; private set; }

        /// <summary>
        /// Gets the ITasksOperations.
        /// </summary>
        public virtual ITasksOperations Tasks { get; private set; }

        /// <summary>
        /// Initializes a new instance of the ContainerRegistryManagementClient class.
        /// </summary>
        /// <param name="restClient">RestClient to be used</param>
        public ContainerRegistryManagementClient(RestClient restClient)
            : base(restClient)
        {
        }

        private ContainerRegistryManagementClient(RestClient restClient, System.Net.Http.HttpClient httpClient) : base(restClient, httpClient)
        {
        }

        public static ContainerRegistryManagementClient NewInstance(RestClient restClient)
        {
            return restClient.HttpClient == null ? new ContainerRegistryManagementClient(restClient) : new ContainerRegistryManagementClient(restClient, restClient.HttpClient);
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        protected override void Initialize()
        {
            Registries = new RegistriesOperations(this);
            Operations = new Operations(this);
            Replications = new ReplicationsOperations(this);
            Webhooks = new WebhooksOperations(this);
            Runs = new RunsOperations(this);
            Tasks = new TasksOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<RunRequestInner>("type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<RunRequestInner>("type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<TaskStepProperties>("type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<TaskStepProperties>("type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<TaskStepUpdateParameters>("type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<TaskStepUpdateParameters>("type"));
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
