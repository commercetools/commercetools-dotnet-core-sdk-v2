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
using System.Collections.Generic;
using Xunit;
using commercetools.Sdk.Api.Models.Subscriptions;

using static commercetools.Api.IntegrationTests.Subscriptions.SubscriptionFixture;


namespace commercetools.Api.IntegrationTests.Subscriptions
{
    [Collection("Integration Tests")]
    public class SubscriptionsIntegrationTests
    {
        // private readonly ProjectApiRoot _projectApiRoot;

        // public ProductTypeIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        // {
        //     this._projectApiRoot = serviceProviderFixture.GetService<ProjectApiRoot>();
        // }

        private readonly IClient _client;
        private readonly string _projectKey;

        public SubscriptionsIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            var clientConfiguration = serviceProviderFixture.GetClientConfiguration("Client");
            this._client = serviceProviderFixture.GetService<IClient>();
            this._projectKey = clientConfiguration.ProjectKey;
        }

        [Fact]
        public async Task ChangeSubscription()
        {
            await WithUpdateableSubscription(_client, async subscription => 
            {
                Assert.NotNull(subscription);

                List<IChangeSubscription> changeSubscriptionList = new List<IChangeSubscription>
                {
                    new ChangeSubscription { ResourceTypeId = IChangeSubscriptionResourceTypeId.Product }
                };

                var action = new SubscriptionSetChangesAction
                {
                    Changes = changeSubscriptionList
                };
                var update = new SubscriptionUpdate
                {
                    Version = subscription.Version,
                    Actions = new List<ISubscriptionUpdateAction> { action }
                };

                var updatedSubscription = await _client.WithApi().WithProjectKey(_projectKey)
                    .Subscriptions()
                    .WithId(subscription.Id)
                    .Post(update)
                    .ExecuteAsync();

                Assert.NotNull(updatedSubscription);
                Assert.Equal(subscription.Id, updatedSubscription.Id);
                return updatedSubscription;
            });
        }
    }
}