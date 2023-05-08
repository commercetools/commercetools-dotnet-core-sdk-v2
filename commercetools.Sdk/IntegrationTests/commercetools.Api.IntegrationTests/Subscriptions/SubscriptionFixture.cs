using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using static commercetools.Api.IntegrationTests.GenericFixture;
using commercetools.Sdk.Api.Models.Subscriptions;

namespace commercetools.Api.IntegrationTests.Subscriptions
{
    public class SubscriptionFixture
    {
        public static SubscriptionDraft DefaultSubscriptionDraft(SubscriptionDraft subscriptionDraft)
        {
            subscriptionDraft.Key = TestingUtility.RandomString();
            subscriptionDraft.Destination = new AzureServiceBusDestination();
            subscriptionDraft.Messages = new List<IMessageSubscription>();
            
            return subscriptionDraft;
        }

        #region CreateAndDelete

        public static async Task<ISubscription> CreateSubscription(IClient client, SubscriptionDraft subscriptionDraft)
        {
            return await CreateSubscription(client.WithProject(DefaultProjectKey), subscriptionDraft);
        }

        public static async Task<ISubscription> CreateSubscription(ProjectApiRoot apiRoot, SubscriptionDraft subscriptionDraft)
        {
            return await apiRoot
                .Subscriptions()
                .Post(subscriptionDraft)
                .ExecuteAsync();
        }

        public static async Task DeleteSubscription(IClient client, ISubscription subscription)
        {
            await DeleteSubscription(client.WithProject(DefaultProjectKey), subscription);
        }

        public static async Task DeleteSubscription(ProjectApiRoot apiRoot, ISubscription subscription)
        {
            try
            {
                await apiRoot
                    .Subscriptions()
                    .WithId(subscription.Id)
                    .Delete()
                    .WithVersion(subscription.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public static async Task<ISubscription> CreateOrRetrieveSubscription(IClient client,
            SubscriptionDraft subscriptionDraft)
        {
            return await CreateOrRetrieveSubscription(client.WithProject(DefaultProjectKey), subscriptionDraft);
        }
        public static async Task<ISubscription> CreateOrRetrieveSubscription(ProjectApiRoot apiRoot, SubscriptionDraft subscriptionDraft)
        {
            ISubscription subscription = null;
            try
            {
                subscription = await apiRoot
                    .Subscriptions()
                    .WithKey(subscriptionDraft.Key)
                    .Get()
                    .ExecuteAsync();
            }
            catch (NotFoundException)
            {
                subscription = await apiRoot
                    .Subscriptions()
                    .Post(subscriptionDraft).ExecuteAsync();
            }

            return subscription;
        }
        #endregion

        #region WithSubscription
        public static async Task WithSubscription(ProjectApiRoot apiRoot, Func<ISubscription, Task> func)
        {
            await WithAsync(apiRoot, new SubscriptionDraft(), DefaultSubscriptionDraft, func, CreateSubscription, DeleteSubscription);
        }

        public static async Task WithSubscription(IClient client, Func<ISubscription, Task> func)
        {
            await WithAsync(client, new SubscriptionDraft(), DefaultSubscriptionDraft, func, CreateSubscription, DeleteSubscription);
        }

        public static async Task WithUpdateableSubscription(IClient client, Func<ISubscription, Task<ISubscription>> func)
        {
            await WithUpdateableAsync(client, new SubscriptionDraft(), DefaultSubscriptionDraft, func, CreateSubscription, DeleteSubscription);
        }
        #endregion
    }
}