// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.ServiceBus.Fluent.TopicAuthorizationRule.Update
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions;
    using Microsoft.Azure.Management.ServiceBus.Fluent.AuthorizationRule.Update;
    using Microsoft.Azure.Management.ServiceBus.Fluent;

    /// <summary>
    /// The entirety of the topic authorization rule update.
    /// </summary>
    public interface IUpdate :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.IAppliable<Microsoft.Azure.Management.ServiceBus.Fluent.ITopicAuthorizationRule>,
        Microsoft.Azure.Management.ServiceBus.Fluent.AuthorizationRule.Update.IWithListenOrSendOrManage<Microsoft.Azure.Management.ServiceBus.Fluent.TopicAuthorizationRule.Update.IUpdate>
    {
    }
}