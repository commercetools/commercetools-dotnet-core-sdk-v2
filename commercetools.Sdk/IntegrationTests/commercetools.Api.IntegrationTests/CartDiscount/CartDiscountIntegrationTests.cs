using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Customers;
using Xunit;
using static commercetools.Api.IntegrationTests.CartDiscount.CartDiscountFixtures;

namespace commercetools.Api.IntegrationTests.CartDiscount
{
    [Collection("Integration Tests")]
    public class CartDiscountIntegrationTests
    {
        private readonly IClient _client;
        private readonly string _projectKey;

        public CartDiscountIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            var clientConfiguration = serviceProviderFixture.GetClientConfiguration("Client");
            this._client = serviceProviderFixture.GetService<IClient>();
            this._projectKey = clientConfiguration.ProjectKey;
        }

        [Fact]
        public async Task CreateCartDiscount()
        {
            var key = $"CreateCartDiscount-{TestingUtility.RandomString()}";
            await WithCartDiscount(
                _client,
                cartDiscountDraft => DefaultCartDiscountDraftWithKey(cartDiscountDraft, key),
                cartDiscount => { Assert.Equal(key, cartDiscount.Key); }
            );
        }

        [Fact]
        public async Task GetCartDiscountById()
        {
            var key = $"GetDiscountById-{TestingUtility.RandomString()}";
            await WithCartDiscount(
                _client,
                cartDiscountDraft => DefaultCartDiscountDraftWithKey(cartDiscountDraft, key),
                async cartDiscount =>
                {
                    Assert.NotNull(cartDiscount);
                    var retrievedCartDiscount = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .CartDiscounts()
                        .WithId(cartDiscount.Id)
                        .Get()
                        .ExecuteAsync();

                    Assert.NotNull(retrievedCartDiscount);
                    Assert.Equal(key, retrievedCartDiscount.Key);
                }
            );
        }

        [Fact]
        public async Task QueryCustomers()
        {
            var key = $"QueryCustomers-{TestingUtility.RandomString()}";
            await WithCartDiscount(
                _client,
                cartDiscountDraft => DefaultCartDiscountDraftWithKey(cartDiscountDraft, key),
                async cartDiscount =>
                {
                    Assert.NotNull(cartDiscount);
                    var returnedSet = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .CartDiscounts()
                        .Get()
                        .WithQuery(q => q.Key().Is(cartDiscount.Key))
                        .ExecuteAsync();

                    Assert.Single(returnedSet.Results);
                    Assert.Equal(key, returnedSet.Results[0].Key);
                });
        }

        [Fact]
        public async Task UpdateCustomerByIdChangeFirstName()
        {
            await WithUpdateableCartDiscount(
                _client,
                async cartDiscount =>
                {
                    Assert.NotNull(cartDiscount);
                    var key = $"{TestingUtility.RandomString()}";
                    var action = new CartDiscountSetKeyAction()
                    {
                        Action = "setKey",
                        Key = key
                    };

                    var update = new CartDiscountUpdate()
                    {
                        Version = cartDiscount.Version,
                        Actions = new List<ICartDiscountUpdateAction>() { action }
                    };

                    var updatedCartDiscount = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .CartDiscounts()
                        .WithId(cartDiscount.Id)
                        .Post(update)
                        .ExecuteAsync();

                    Assert.Equal(updatedCartDiscount.Key, key);
                    return updatedCartDiscount;
                }
            );
        }
    }
}