using commercetools.Api.Models.Orders;
using commercetools.Base.Client;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace commercetools.Api.Serialization.Tests
{
    public class OrderSearchTests
    {
        private IClient GetClient()
        {
            var s = new ServiceCollection();
            s.UseCommercetoolsApiSerialization();
            var p = s.BuildServiceProvider();

            return new CtpClient(null, p.GetService<SerializerService>());
        }

        [Fact]
        public void orderSearchQuery()
        {
            var apiRoot = ApiFactory.CreateForProject(GetClient(), "");
            var request = apiRoot
                .Orders()
                .Search()
                .Post(new OrderSearchRequest()
                {
                    Query = new Query()
                });

            var body = request.Build().Content.ReadAsStringAsync().Result;
            Assert.Equal("{\"query\":{\"exact\":{\"field\":\"itemShippingAddresses.postalCode\",\"value\":\"EC1R 5EN\"}}}", body);
        }

        private class Query : IOrderSearchQuery
        {
            public object Exact { get; set; } = new
            {
                field = "itemShippingAddresses.postalCode",
                value = "EC1R 5EN"
            };
        }
    }
}