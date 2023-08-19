// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// DomainsOperations operations.
    /// </summary>
    public partial interface IDomainsOperations
    {
        /// <summary>
        /// Check if a domain is available for registration.
        /// </summary>
        /// <remarks>
        /// Description for Check if a domain is available for registration.
        /// </remarks>
        /// <param name='name'>
        /// Name of the object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DomainAvailabilityCheckResultInner>> CheckAvailabilityWithHttpMessagesAsync(string name = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all domains in a subscription.
        /// </summary>
        /// <remarks>
        /// Description for Get all domains in a subscription.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<DomainInner>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generate a single sign-on request for the domain management portal.
        /// </summary>
        /// <remarks>
        /// Description for Generate a single sign-on request for the domain
        /// management portal.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DomainControlCenterSsoRequestInner>> GetControlCenterSsoRequestWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get domain name recommendations based on keywords.
        /// </summary>
        /// <remarks>
        /// Description for Get domain name recommendations based on keywords.
        /// </remarks>
        /// <param name='parameters'>
        /// Search parameters for domain name recommendations.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<NameIdentifier>>> ListRecommendationsWithHttpMessagesAsync(DomainRecommendationSearchParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all domains in a resource group.
        /// </summary>
        /// <remarks>
        /// Description for Get all domains in a resource group.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<DomainInner>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a domain.
        /// </summary>
        /// <remarks>
        /// Description for Get a domain.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='domainName'>
        /// Name of the domain.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DomainInner>> GetWithHttpMessagesAsync(string resourceGroupName, string domainName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a domain.
        /// </summary>
        /// <remarks>
        /// Description for Creates or updates a domain.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='domainName'>
        /// Name of the domain.
        /// </param>
        /// <param name='domain'>
        /// Domain registration information.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DomainInner>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string domainName, DomainInner domain, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a domain.
        /// </summary>
        /// <remarks>
        /// Description for Delete a domain.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='domainName'>
        /// Name of the domain.
        /// </param>
        /// <param name='forceHardDeleteDomain'>
        /// Specify &lt;code&gt;true&lt;/code&gt; to delete the domain
        /// immediately. The default is &lt;code&gt;false&lt;/code&gt; which
        /// deletes the domain after 24 hours.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string domainName, bool? forceHardDeleteDomain = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a domain.
        /// </summary>
        /// <remarks>
        /// Description for Creates or updates a domain.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='domainName'>
        /// Name of the domain.
        /// </param>
        /// <param name='domain'>
        /// Domain registration information.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DomainInner>> UpdateWithHttpMessagesAsync(string resourceGroupName, string domainName, DomainPatchResource domain, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists domain ownership identifiers.
        /// </summary>
        /// <remarks>
        /// Description for Lists domain ownership identifiers.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='domainName'>
        /// Name of domain.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<DomainOwnershipIdentifierInner>>> ListOwnershipIdentifiersWithHttpMessagesAsync(string resourceGroupName, string domainName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get ownership identifier for domain
        /// </summary>
        /// <remarks>
        /// Description for Get ownership identifier for domain
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='domainName'>
        /// Name of domain.
        /// </param>
        /// <param name='name'>
        /// Name of identifier.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DomainOwnershipIdentifierInner>> GetOwnershipIdentifierWithHttpMessagesAsync(string resourceGroupName, string domainName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates an ownership identifier for a domain or updates identifier
        /// details for an existing identifer
        /// </summary>
        /// <remarks>
        /// Description for Creates an ownership identifier for a domain or
        /// updates identifier details for an existing identifer
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='domainName'>
        /// Name of domain.
        /// </param>
        /// <param name='name'>
        /// Name of identifier.
        /// </param>
        /// <param name='domainOwnershipIdentifier'>
        /// A JSON representation of the domain ownership properties.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DomainOwnershipIdentifierInner>> CreateOrUpdateOwnershipIdentifierWithHttpMessagesAsync(string resourceGroupName, string domainName, string name, DomainOwnershipIdentifierInner domainOwnershipIdentifier, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete ownership identifier for domain
        /// </summary>
        /// <remarks>
        /// Description for Delete ownership identifier for domain
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='domainName'>
        /// Name of domain.
        /// </param>
        /// <param name='name'>
        /// Name of identifier.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteOwnershipIdentifierWithHttpMessagesAsync(string resourceGroupName, string domainName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates an ownership identifier for a domain or updates identifier
        /// details for an existing identifer
        /// </summary>
        /// <remarks>
        /// Description for Creates an ownership identifier for a domain or
        /// updates identifier details for an existing identifer
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='domainName'>
        /// Name of domain.
        /// </param>
        /// <param name='name'>
        /// Name of identifier.
        /// </param>
        /// <param name='domainOwnershipIdentifier'>
        /// A JSON representation of the domain ownership properties.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DomainOwnershipIdentifierInner>> UpdateOwnershipIdentifierWithHttpMessagesAsync(string resourceGroupName, string domainName, string name, DomainOwnershipIdentifierInner domainOwnershipIdentifier, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Renew a domain.
        /// </summary>
        /// <remarks>
        /// Description for Renew a domain.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='domainName'>
        /// Name of the domain.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> RenewWithHttpMessagesAsync(string resourceGroupName, string domainName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a domain.
        /// </summary>
        /// <remarks>
        /// Description for Creates or updates a domain.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='domainName'>
        /// Name of the domain.
        /// </param>
        /// <param name='domain'>
        /// Domain registration information.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DomainInner>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string domainName, DomainInner domain, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all domains in a subscription.
        /// </summary>
        /// <remarks>
        /// Description for Get all domains in a subscription.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<DomainInner>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get domain name recommendations based on keywords.
        /// </summary>
        /// <remarks>
        /// Description for Get domain name recommendations based on keywords.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<NameIdentifier>>> ListRecommendationsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all domains in a resource group.
        /// </summary>
        /// <remarks>
        /// Description for Get all domains in a resource group.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<DomainInner>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists domain ownership identifiers.
        /// </summary>
        /// <remarks>
        /// Description for Lists domain ownership identifiers.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<DomainOwnershipIdentifierInner>>> ListOwnershipIdentifiersNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
