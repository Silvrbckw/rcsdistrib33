// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AgentPoolsOperations.
    /// </summary>
    public static partial class AgentPoolsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of agent pools in the specified managed cluster.
            /// </summary>
            /// <remarks>
            /// Gets a list of agent pools in the specified managed cluster. The operation
            /// returns properties of each agent pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AgentPoolInner>> ListAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the agent pool.
            /// </summary>
            /// <remarks>
            /// Gets the details of the agent pool by managed cluster and resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgentPoolInner> GetAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, agentPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an agent pool.
            /// </summary>
            /// <remarks>
            /// Creates or updates an agent pool in the specified managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or Update an agent pool operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgentPoolInner> CreateOrUpdateAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName, AgentPoolInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, agentPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an agent pool.
            /// </summary>
            /// <remarks>
            /// Deletes the agent pool in the specified managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, agentPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets upgrade profile for an agent pool.
            /// </summary>
            /// <remarks>
            /// Gets the details of the upgrade profile for an agent pool with a specified
            /// resource group and managed cluster name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgentPoolUpgradeProfileInner> GetUpgradeProfileAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetUpgradeProfileWithHttpMessagesAsync(resourceGroupName, resourceName, agentPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of supported versions for the specified agent pool.
            /// </summary>
            /// <remarks>
            /// Gets a list of supported versions for the specified agent pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgentPoolAvailableVersionsInner> GetAvailableAgentPoolVersionsAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAvailableAgentPoolVersionsWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Upgrade node image version of an agent pool to the latest.
            /// </summary>
            /// <remarks>
            /// Upgrade node image version of an agent pool to the latest.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgentPoolInner> UpgradeNodeImageVersionAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpgradeNodeImageVersionWithHttpMessagesAsync(resourceGroupName, resourceName, agentPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an agent pool.
            /// </summary>
            /// <remarks>
            /// Creates or updates an agent pool in the specified managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or Update an agent pool operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgentPoolInner> BeginCreateOrUpdateAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName, AgentPoolInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, agentPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an agent pool.
            /// </summary>
            /// <remarks>
            /// Deletes the agent pool in the specified managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, resourceName, agentPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Upgrade node image version of an agent pool to the latest.
            /// </summary>
            /// <remarks>
            /// Upgrade node image version of an agent pool to the latest.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgentPoolInner> BeginUpgradeNodeImageVersionAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpgradeNodeImageVersionWithHttpMessagesAsync(resourceGroupName, resourceName, agentPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of agent pools in the specified managed cluster.
            /// </summary>
            /// <remarks>
            /// Gets a list of agent pools in the specified managed cluster. The operation
            /// returns properties of each agent pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AgentPoolInner>> ListNextAsync(this IAgentPoolsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
