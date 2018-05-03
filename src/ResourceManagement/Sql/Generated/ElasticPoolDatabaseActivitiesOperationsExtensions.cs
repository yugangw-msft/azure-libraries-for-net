// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ElasticPoolDatabaseActivitiesOperations.
    /// </summary>
    public static partial class ElasticPoolDatabaseActivitiesOperationsExtensions
    {
            /// <summary>
            /// Returns activity on databases inside of an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ElasticPoolDatabaseActivity>> ListByElasticPoolAsync(this IElasticPoolDatabaseActivitiesOperations operations, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByElasticPoolWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
