using System.Collections.Generic;
using commercetools.Sdk.Api.Models.Subscriptions;
using commercetools.Sdk.Api.Serialization;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
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
            JToken resultFormatted = JValue.Parse(json);
            var serialized =
                "{\"changes\":[{\"resourceTypeId\":\"product\"}],\"destination\":{\"type\":\"AzureServiceBus\",\"connectionString\":\"\"},\"key\":\"azure-product-subscription\"}";
            
            JToken serializedFormatted = JValue.Parse(serialized);
            serializedFormatted.Should().BeEquivalentTo(resultFormatted);

        }
    }
}