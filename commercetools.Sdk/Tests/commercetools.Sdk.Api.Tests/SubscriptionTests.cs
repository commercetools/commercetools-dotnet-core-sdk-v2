using System.Collections.Generic;
using commercetools.Sdk.Api.Models.Subscriptions;
using commercetools.Sdk.Api.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace commercetools.Sdk.Api.Tests
{
    public class SubscriptionTests
    {
        [Fact]
        public void testSubscriptionDraft()
        {
            var s = new ServiceCollection();
            s.UseCommercetoolsApiSerialization();
            var p = s.BuildServiceProvider();
            var serializerService = p.GetService<IApiSerializerService>();
            var subscriptionDraft = new SubscriptionDraft()
            {
                Key = "azure-product-subscription",
                Destination = new AzureServiceBusDestination()
                {
                    ConnectionString = ""
                },
                Changes = new List<IChangeSubscription>()
                {
                    new ChangeSubscription() { ResourceTypeId = IChangeSubscriptionResourceTypeId.Product }
                }
            };

            var json = serializerService.Serialize(subscriptionDraft);
            
            Assert.Equal("{\"changes\":[{\"resourceTypeId\":\"product\"}],\"destination\":{\"type\":\"AzureServiceBus\",\"connectionString\":\"\"},\"key\":\"azure-product-subscription\"}", json);
        }
    }
}