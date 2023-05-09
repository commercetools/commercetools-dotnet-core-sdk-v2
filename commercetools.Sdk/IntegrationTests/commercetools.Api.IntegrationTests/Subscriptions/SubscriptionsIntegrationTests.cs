using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using commercetools.Sdk.Api.Models.Subscriptions;
using static commercetools.Api.IntegrationTests.Subscriptions.SubscriptionFixture;


namespace commercetools.Api.IntegrationTests.Subscriptions

    [Collection("Integration Tests")]
    public class SubscriptionsIntegrationTests
    {
        private readonly ProjectApiRoot _projectApiRoot;

        public SubscriptionsIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._projectApiRoot = serviceProviderFixture.GetService<ProjectApiRoot>();
        }

        [Fact]
        public async Task ChangeSubscription()
        {
            await WithUpdateableSubscription(_client, async subscription => 
            {
                Assert.NotNull(subscription);

                var action = new SubscriptionSetChangesAction
                {
                    Changes = new List<IChangeSubscription> {
                            {
                                ResourceTypeId = "product"
                            }
                        }
                };
                var update = new SubscriptionUpdate
                {
                    Version = subscription.Version,
                    Actions = new List<ISubscriptionUpdateAction> { action }
                };

                var updatedSubscription = await _projectApiRoot
                    .Subscriptions()
                    .WithKey(subscription.Key)
                    .Post(update)
                    .ExecuteAsync();

                Assert.NotNull(updatedSubscription);
                Assert.Equal(subscription.key, updatedSubscription.key);
                return updatedSubscription;
            });
        }
        #endregion
    }
