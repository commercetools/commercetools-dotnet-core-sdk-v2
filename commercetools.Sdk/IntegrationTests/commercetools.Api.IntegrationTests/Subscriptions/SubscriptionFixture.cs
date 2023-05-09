using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.Subscriptions;
using static commercetools.Api.IntegrationTests.GenericFixture;

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
            return await client.WithApi().WithProjectKey(DefaultProjectKey)
                .Subscriptions()
                .Post(subscriptionDraft)
                .ExecuteAsync();
        }

        public static async Task DeleteSubscription(IClient client, ISubscription subscription)
        {
            try
            {
                await client.WithApi().WithProjectKey(DefaultProjectKey)
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

        #endregion

        #region WithSubscription
        public static async Task WithSubscription(IClient client, Func<SubscriptionDraft, SubscriptionDraft> draftAction, Action<ISubscription> func)
        {
            await With(client, new SubscriptionDraft(), draftAction, func, CreateSubscription, DeleteSubscription);
        }
        public static async Task WithSubscription(IClient client, Func<SubscriptionDraft, SubscriptionDraft> draftAction, Func<ISubscription, Task> func)
        {
            await WithAsync(client, new SubscriptionDraft(), draftAction, func, CreateSubscription, DeleteSubscription);
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