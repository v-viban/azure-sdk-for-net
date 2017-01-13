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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for NamespacesOperations.
    /// </summary>
    public static partial class NamespacesOperationsExtensions
    {
            /// <summary>
            /// Create Azure Relay namespace.
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
            /// <param name='parameters'>
            /// Parameters supplied to create a Namespace Resource.
            /// </param>
            public static NamespaceResource Create(this INamespacesOperations operations, string resourceGroupName, string namespaceName, NamespaceResource parameters)
            {
                return operations.CreateAsync(resourceGroupName, namespaceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create Azure Relay namespace.
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
            /// <param name='parameters'>
            /// Parameters supplied to create a Namespace Resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NamespaceResource> CreateAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, NamespaceResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, namespaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates properties of Azure Relay namespace.
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
            /// <param name='parameters'>
            /// Parameters supplied to create a Namespace Resource.
            /// </param>
            public static NamespaceResource Patch(this INamespacesOperations operations, string resourceGroupName, string namespaceName, NamespaceResource parameters)
            {
                return operations.PatchAsync(resourceGroupName, namespaceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates properties of Azure Relay namespace.
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
            /// <param name='parameters'>
            /// Parameters supplied to create a Namespace Resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NamespaceResource> PatchAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, NamespaceResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchWithHttpMessagesAsync(resourceGroupName, namespaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing namespace. This operation also removes all associated
            /// resources under the namespace.
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
            public static void Delete(this INamespacesOperations operations, string resourceGroupName, string namespaceName)
            {
                operations.DeleteAsync(resourceGroupName, namespaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing namespace. This operation also removes all associated
            /// resources under the namespace.
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
            public static async Task DeleteAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns the description for the specified namespace.
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
            public static NamespaceResource Get(this INamespacesOperations operations, string resourceGroupName, string namespaceName)
            {
                return operations.GetAsync(resourceGroupName, namespaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the description for the specified namespace.
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
            public static async Task<NamespaceResource> GetAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the available namespaces within the subscription irrespective of
            /// the resourceGroups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<NamespaceResource> List(this INamespacesOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the available namespaces within the subscription irrespective of
            /// the resourceGroups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NamespaceResource>> ListAsync(this INamespacesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the available namespaces within the ResourceGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<NamespaceResource> ListByResourceGroup(this INamespacesOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the available namespaces within the ResourceGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NamespaceResource>> ListByResourceGroupAsync(this INamespacesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Authorization rules for a namespace.
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
            public static IPage<SharedAccessAuthorizationRuleResource> ListAuthorizationRules(this INamespacesOperations operations, string resourceGroupName, string namespaceName)
            {
                return operations.ListAuthorizationRulesAsync(resourceGroupName, namespaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Authorization rules for a namespace.
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SharedAccessAuthorizationRuleResource>> ListAuthorizationRulesAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or Updates an authorization rule for a namespace
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639410.aspx" />
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
            /// <param name='authorizationRuleName'>
            /// Namespace Aauthorization Rule Name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access authorization rule.
            /// </param>
            public static SharedAccessAuthorizationRuleResource CreateOrUpdateAuthorizationRule(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters parameters)
            {
                return operations.CreateOrUpdateAuthorizationRuleAsync(resourceGroupName, namespaceName, authorizationRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or Updates an authorization rule for a namespace
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639410.aspx" />
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
            /// <param name='authorizationRuleName'>
            /// Namespace Aauthorization Rule Name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access authorization rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedAccessAuthorizationRuleResource> CreateOrUpdateAuthorizationRuleAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a namespace authorization rule
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
            /// <param name='authorizationRuleName'>
            /// Authorization Rule Name.
            /// </param>
            public static void DeleteAuthorizationRule(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName)
            {
                operations.DeleteAuthorizationRuleAsync(resourceGroupName, namespaceName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a namespace authorization rule
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
            /// <param name='authorizationRuleName'>
            /// Authorization Rule Name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAuthorizationRuleAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Authorization rule for a namespace by name.
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
            /// <param name='authorizationRuleName'>
            /// Authorization rule name.
            /// </param>
            public static SharedAccessAuthorizationRuleResource GetAuthorizationRule(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName)
            {
                return operations.GetAuthorizationRuleAsync(resourceGroupName, namespaceName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Authorization rule for a namespace by name.
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
            /// <param name='authorizationRuleName'>
            /// Authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedAccessAuthorizationRuleResource> GetAuthorizationRuleAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Primary and Secondary ConnectionStrings to the namespace
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
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            public static ResourceListKeys ListKeys(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName)
            {
                return operations.ListKeysAsync(resourceGroupName, namespaceName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Primary and Secondary ConnectionStrings to the namespace
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
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceListKeys> ListKeysAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerats the Primary or Secondary ConnectionStrings to the namespace
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
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            /// <param name='policykey'>
            /// Key that needs to be regenerated. Possible values include: 'primaryKey',
            /// 'secondaryKey'
            /// </param>
            public static ResourceListKeys RegenerateKeys(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, Policykey? policykey = default(Policykey?))
            {
                return operations.RegenerateKeysAsync(resourceGroupName, namespaceName, authorizationRuleName, policykey).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerats the Primary or Secondary ConnectionStrings to the namespace
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
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            /// <param name='policykey'>
            /// Key that needs to be regenerated. Possible values include: 'primaryKey',
            /// 'secondaryKey'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceListKeys> RegenerateKeysAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, Policykey? policykey = default(Policykey?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, authorizationRuleName, policykey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create Azure Relay namespace.
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
            /// <param name='parameters'>
            /// Parameters supplied to create a Namespace Resource.
            /// </param>
            public static NamespaceResource BeginCreate(this INamespacesOperations operations, string resourceGroupName, string namespaceName, NamespaceResource parameters)
            {
                return operations.BeginCreateAsync(resourceGroupName, namespaceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create Azure Relay namespace.
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
            /// <param name='parameters'>
            /// Parameters supplied to create a Namespace Resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NamespaceResource> BeginCreateAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, NamespaceResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, namespaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates properties of Azure Relay namespace.
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
            /// <param name='parameters'>
            /// Parameters supplied to create a Namespace Resource.
            /// </param>
            public static NamespaceResource BeginPatch(this INamespacesOperations operations, string resourceGroupName, string namespaceName, NamespaceResource parameters)
            {
                return operations.BeginPatchAsync(resourceGroupName, namespaceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates properties of Azure Relay namespace.
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
            /// <param name='parameters'>
            /// Parameters supplied to create a Namespace Resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NamespaceResource> BeginPatchAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, NamespaceResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginPatchWithHttpMessagesAsync(resourceGroupName, namespaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing namespace. This operation also removes all associated
            /// resources under the namespace.
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
            public static void BeginDelete(this INamespacesOperations operations, string resourceGroupName, string namespaceName)
            {
                operations.BeginDeleteAsync(resourceGroupName, namespaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing namespace. This operation also removes all associated
            /// resources under the namespace.
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
            public static async Task BeginDeleteAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Lists all the available namespaces within the subscription irrespective of
            /// the resourceGroups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NamespaceResource> ListNext(this INamespacesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the available namespaces within the subscription irrespective of
            /// the resourceGroups.
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
            public static async Task<IPage<NamespaceResource>> ListNextAsync(this INamespacesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the available namespaces within the ResourceGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NamespaceResource> ListByResourceGroupNext(this INamespacesOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the available namespaces within the ResourceGroup.
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
            public static async Task<IPage<NamespaceResource>> ListByResourceGroupNextAsync(this INamespacesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Authorization rules for a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SharedAccessAuthorizationRuleResource> ListAuthorizationRulesNext(this INamespacesOperations operations, string nextPageLink)
            {
                return operations.ListAuthorizationRulesNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Authorization rules for a namespace.
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
            public static async Task<IPage<SharedAccessAuthorizationRuleResource>> ListAuthorizationRulesNextAsync(this INamespacesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

