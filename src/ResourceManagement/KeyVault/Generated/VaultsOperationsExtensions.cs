// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Fluent
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VaultsOperations.
    /// </summary>
    public static partial class VaultsOperationsExtensions
    {
            /// <summary>
            /// Create or update a key vault in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the server belongs.
            /// </param>
            /// <param name='vaultName'>
            /// Name of the vault
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create or update the vault
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VaultInner> CreateOrUpdateAsync(this IVaultsOperations operations, string resourceGroupName, string vaultName, VaultCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vaultName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a key vault in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the server belongs.
            /// </param>
            /// <param name='vaultName'>
            /// Name of the vault
            /// </param>
            /// <param name='parameters'>
            /// Parameters to patch the vault
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VaultInner> UpdateAsync(this IVaultsOperations operations, string resourceGroupName, string vaultName, VaultPatchParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, vaultName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified Azure key vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the vault belongs.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the vault to delete
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVaultsOperations operations, string resourceGroupName, string vaultName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, vaultName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified Azure key vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the vault belongs.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the vault.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VaultInner> GetAsync(this IVaultsOperations operations, string resourceGroupName, string vaultName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, vaultName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update access policies in a key vault in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the vault belongs.
            /// </param>
            /// <param name='vaultName'>
            /// Name of the vault
            /// </param>
            /// <param name='operationKind'>
            /// Name of the operation. Possible values include: 'add', 'replace', 'remove'
            /// </param>
            /// <param name='properties'>
            /// Properties of the access policy
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VaultAccessPolicyParametersInner> UpdateAccessPolicyAsync(this IVaultsOperations operations, string resourceGroupName, string vaultName, AccessPolicyUpdateKind operationKind, VaultAccessPolicyProperties properties, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateAccessPolicyWithHttpMessagesAsync(resourceGroupName, vaultName, operationKind, properties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List operation gets information about the vaults associated with the
            /// subscription and within the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the vault belongs.
            /// </param>
            /// <param name='top'>
            /// Maximum number of results to return.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VaultInner>> ListByResourceGroupAsync(this IVaultsOperations operations, string resourceGroupName, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List operation gets information about the vaults associated with the
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Maximum number of results to return.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VaultInner>> ListBySubscriptionAsync(this IVaultsOperations operations, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about the deleted vaults in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DeletedVaultInner>> ListDeletedAsync(this IVaultsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListDeletedWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the deleted Azure key vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the vault.
            /// </param>
            /// <param name='location'>
            /// The location of the deleted vault.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeletedVaultInner> GetDeletedAsync(this IVaultsOperations operations, string vaultName, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDeletedWithHttpMessagesAsync(vaultName, location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Permanently deletes the specified vault. aka Purges the deleted Azure key
            /// vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the soft-deleted vault.
            /// </param>
            /// <param name='location'>
            /// The location of the soft-deleted vault.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PurgeDeletedAsync(this IVaultsOperations operations, string vaultName, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PurgeDeletedWithHttpMessagesAsync(vaultName, location, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The List operation gets information about the vaults associated with the
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Maximum number of results to return.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Management.ResourceManager.Fluent.SubResource>> ListAsync(this IVaultsOperations operations, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Checks that the vault name is valid and is not already in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// The vault name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckNameAvailabilityResultInner> CheckNameAvailabilityAsync(this IVaultsOperations operations, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a key vault in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the server belongs.
            /// </param>
            /// <param name='vaultName'>
            /// Name of the vault
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create or update the vault
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VaultInner> BeginCreateOrUpdateAsync(this IVaultsOperations operations, string resourceGroupName, string vaultName, VaultCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vaultName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Permanently deletes the specified vault. aka Purges the deleted Azure key
            /// vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the soft-deleted vault.
            /// </param>
            /// <param name='location'>
            /// The location of the soft-deleted vault.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginPurgeDeletedAsync(this IVaultsOperations operations, string vaultName, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginPurgeDeletedWithHttpMessagesAsync(vaultName, location, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The List operation gets information about the vaults associated with the
            /// subscription and within the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VaultInner>> ListByResourceGroupNextAsync(this IVaultsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List operation gets information about the vaults associated with the
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VaultInner>> ListBySubscriptionNextAsync(this IVaultsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about the deleted vaults in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DeletedVaultInner>> ListDeletedNextAsync(this IVaultsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListDeletedNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List operation gets information about the vaults associated with the
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Management.ResourceManager.Fluent.SubResource>> ListNextAsync(this IVaultsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}