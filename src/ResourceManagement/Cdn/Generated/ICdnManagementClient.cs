// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Cdn Management Client
    /// </summary>
    public partial interface ICdnManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Azure Subscription ID.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Version of the API to be used with the client request. Current
        /// version is 2017-04-02.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IProfilesOperations.
        /// </summary>
        IProfilesOperations Profiles { get; }

        /// <summary>
        /// Gets the IEndpointsOperations.
        /// </summary>
        IEndpointsOperations Endpoints { get; }

        /// <summary>
        /// Gets the IOriginsOperations.
        /// </summary>
        IOriginsOperations Origins { get; }

        /// <summary>
        /// Gets the ICustomDomainsOperations.
        /// </summary>
        ICustomDomainsOperations CustomDomains { get; }

        /// <summary>
        /// Gets the IResourceUsageOperations.
        /// </summary>
        IResourceUsageOperations ResourceUsage { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IEdgeNodesOperations.
        /// </summary>
        IEdgeNodesOperations EdgeNodes { get; }

        /// <summary>
        /// Check the availability of a resource name. This is needed for
        /// resources where name is globally unique, such as a CDN endpoint.
        /// </summary>
        /// <param name='name'>
        /// The resource name to validate.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CheckNameAvailabilityOutputInner>> CheckNameAvailabilityWithHttpMessagesAsync(string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Check the availability of a resource name. This is needed for
        /// resources where name is globally unique, such as a CDN endpoint.
        /// </summary>
        /// <param name='name'>
        /// The resource name to validate.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CheckNameAvailabilityOutputInner>> CheckNameAvailabilityWithSubscriptionWithHttpMessagesAsync(string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Check if the probe path is a valid path and the file can be
        /// accessed. Probe path is the path to a file hosted on the origin
        /// server to help accelerate the delivery of dynamic content via the
        /// CDN endpoint. This path is relative to the origin path specified in
        /// the endpoint configuration.
        /// </summary>
        /// <param name='probeURL'>
        /// The probe URL to validate.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ValidateProbeOutputInner>> ValidateProbeWithHttpMessagesAsync(string probeURL, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
