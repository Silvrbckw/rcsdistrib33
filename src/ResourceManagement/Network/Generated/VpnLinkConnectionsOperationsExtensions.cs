// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VpnLinkConnectionsOperations.
    /// </summary>
    public static partial class VpnLinkConnectionsOperationsExtensions
    {
            /// <summary>
            /// Retrieves all vpn site link connections for a particular virtual wan vpn
            /// gateway vpn connection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the vpn connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VpnSiteLinkConnectionInner>> ListByVpnConnectionAsync(this IVpnLinkConnectionsOperations operations, string resourceGroupName, string gatewayName, string connectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByVpnConnectionWithHttpMessagesAsync(resourceGroupName, gatewayName, connectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves all vpn site link connections for a particular virtual wan vpn
            /// gateway vpn connection.
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
            public static async Task<IPage<VpnSiteLinkConnectionInner>> ListByVpnConnectionNextAsync(this IVpnLinkConnectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByVpnConnectionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
