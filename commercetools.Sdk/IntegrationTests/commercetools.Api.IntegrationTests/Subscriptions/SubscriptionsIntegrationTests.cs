using commercetools.Sdk.Api.Client;
using Xunit;
using commercetools.Sdk.Api.Models.Subscriptions;
using static commercetools.Api.IntegrationTests.Subscriptions.SubscriptionFixture;

namespace commercetools.Api.IntegrationTests.Subscriptions
{
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
            await WithUpdateableSubscription(_client, subscription => 
                {
                    Assert.NotNull(subscription);

                    var action = new SubscriptionSetChangesAction
                    {
                        Changes = new List<IChangeSubscription>(
                            {
                                ResourceTypeId = "product"
                            }
                        )
                    };
                    var update = new SubscriptionUpdate
                    {
                        Version = subscription.Version,
                        Actions = new List<ISubscriptionUpdateAction> { action }
                    };

                    var updatedSubscription = await _client.WithApi().WithProjectKey(_projectKey)
                        .Subscriptions()
                        .WithKey(subscription.Key)
                        .Post(update)
                        .ExecuteAsync();

                    //assertion is missing

                    return updatedSubscription;
            });
        }
        #endregion
    }
}