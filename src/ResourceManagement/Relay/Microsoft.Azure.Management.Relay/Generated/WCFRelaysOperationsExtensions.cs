// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Relay
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WCFRelaysOperations.
    /// </summary>
    public static partial class WCFRelaysOperationsExtensions
    {
            /// <summary>
            /// Creates or Updates a service WCFRelays. This operation is idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='relayName'>
            /// The name of the relay.
            /// </param>
            /// <param name='value'>
            /// Result of the List WcfRelays .
            /// </param>
            /// <param name='nextLink'>
            /// Link to the next set of results. Not empty if Value contains incomplete
            /// list of WcfRelays operation
            /// </param>
            public static WcfRelaysListResult CreateOrUpdate(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, IList<WcfRelaysResource> value = default(IList<WcfRelaysResource>), string nextLink = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, namespaceName, relayName, value, nextLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or Updates a service WCFRelays. This operation is idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='relayName'>
            /// The name of the relay.
            /// </param>
            /// <param name='value'>
            /// Result of the List WcfRelays .
            /// </param>
            /// <param name='nextLink'>
            /// Link to the next set of results. Not empty if Value contains incomplete
            /// list of WcfRelays operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WcfRelaysListResult> CreateOrUpdateAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, IList<WcfRelaysResource> value = default(IList<WcfRelaysResource>), string nextLink = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, relayName, value, nextLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a WCFRelays .
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='relayName'>
            /// The name of the relay.
            /// </param>
            public static void Delete(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName)
            {
                operations.DeleteAsync(resourceGroupName, namespaceName, relayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a WCFRelays .
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='relayName'>
            /// The name of the relay.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, relayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns the description for the specified WCFRelays.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='relayName'>
            /// The name of the relay.
            /// </param>
            public static object Get(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName)
            {
                return operations.GetAsync(resourceGroupName, namespaceName, relayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the description for the specified WCFRelays.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='relayName'>
            /// The name of the relay.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, relayName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the WCFRelays within the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            public static IPage<WcfRelaysResource> ListByNameSpace(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName)
            {
                return operations.ListByNameSpaceAsync(resourceGroupName, namespaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the WCFRelays within the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WcfRelaysResource>> ListByNameSpaceAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByNameSpaceWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or Updates an authorization rule for a WCFRelays
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='relayName'>
            /// The name of the relay.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization Rule Name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access authorization rule.
            /// </param>
            public static SharedAccessAuthorizationRuleResource CreateOrUpdateAuthorizationRule(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters parameters)
            {
                return operations.CreateOrUpdateAuthorizationRuleAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or Updates an authorization rule for a WCFRelays
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='relayName'>
            /// The name of the relay.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization Rule Name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access authorization rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedAccessAuthorizationRuleResource> CreateOrUpdateAuthorizationRuleAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a WCFRelays authorization rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='relayName'>
            /// The name of the relay.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization Rule Name.
            /// </param>
            public static SharedAccessAuthorizationRuleResource DeleteAuthorizationRule(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName)
            {
                return operations.DeleteAuthorizationRuleAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a WCFRelays authorization rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='relayName'>
            /// The name of the relay.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization Rule Name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedAccessAuthorizationRuleResource> DeleteAuthorizationRuleAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get authorizationRule for a WCFRelays by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The name of the relay.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization rule name.
            /// </param>
            public static SharedAccessAuthorizationRuleResource GetAuthorizationRule(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName)
            {
                return operations.GetAuthorizationRuleAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get authorizationRule for a WCFRelays by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='relayName'>
            /// The name of the relay.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedAccessAuthorizationRuleResource> GetAuthorizationRuleAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Primary and Secondary ConnectionStrings to the WCFRelays.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='relayName'>
            /// The name of the relay.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            public static ResourceListKeys ListKeys(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName)
            {
                return operations.ListKeysAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Primary and Secondary ConnectionStrings to the WCFRelays.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='relayName'>
            /// The name of the relay.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceListKeys> ListKeysAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates the Primary or Secondary ConnectionStrings to the WCFRelays
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='relayName'>
            /// The name of the relay.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name
            /// </param>
            /// <param name='policykey'>
            /// Key that needs to be regenerated. Possible values include: 'primaryKey',
            /// 'secondaryKey'
            /// </param>
            public static ResourceListKeys RegenerateKeys(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName, Policykey? policykey = default(Policykey?))
            {
                return operations.RegenerateKeysAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName, policykey).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the Primary or Secondary ConnectionStrings to the WCFRelays
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='relayName'>
            /// The name of the relay.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name
            /// </param>
            /// <param name='policykey'>
            /// Key that needs to be regenerated. Possible values include: 'primaryKey',
            /// 'secondaryKey'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceListKeys> RegenerateKeysAsync(this IWCFRelaysOperations operations, string resourceGroupName, string namespaceName, string relayName, string authorizationRuleName, Policykey? policykey = default(Policykey?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, relayName, authorizationRuleName, policykey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the description for the specified WCFRelays.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static object GetNext(this IWCFRelaysOperations operations, string nextPageLink)
            {
                return operations.GetNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the description for the specified WCFRelays.
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
            public static async Task<object> GetNextAsync(this IWCFRelaysOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the WCFRelays within the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<WcfRelaysResource> ListByNameSpaceNext(this IWCFRelaysOperations operations, string nextPageLink)
            {
                return operations.ListByNameSpaceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the WCFRelays within the namespace.
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
            public static async Task<IPage<WcfRelaysResource>> ListByNameSpaceNextAsync(this IWCFRelaysOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByNameSpaceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
