using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.CartDiscounts;
using Xunit;
using static commercetools.Api.IntegrationTests.CartDiscount.CartDiscountFixtures;

namespace commercetools.Api.IntegrationTests.CartDiscount
{
    [Collection("Integration Tests")]
    public class CartDiscountIntegrationTests
    {
        private readonly ProjectApiRoot _client;

        public CartDiscountIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._client = serviceProviderFixture.GetService<ProjectApiRoot>();
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
        public async Task QueryCartDiscounts()
        {
            var key = $"QueryCartDiscounts-{TestingUtility.RandomString()}";
            await WithCartDiscount(
                _client,
                cartDiscountDraft => DefaultCartDiscountDraftWithKey(cartDiscountDraft, key),
                async cartDiscount =>
                {
                    Assert.NotNull(cartDiscount);
                    var returnedSet = await _client
                        .CartDiscounts()
                        .Get()
                        .WithQuery(q => q.Key().Is(cartDiscount.Key))
                        .ExecuteAsync();

                    Assert.Single(returnedSet.Results);
                    Assert.Equal(key, returnedSet.Results[0].Key);
                });
        }

        [Fact]
        public async Task UpdateCartDiscountByIdSetKey()
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