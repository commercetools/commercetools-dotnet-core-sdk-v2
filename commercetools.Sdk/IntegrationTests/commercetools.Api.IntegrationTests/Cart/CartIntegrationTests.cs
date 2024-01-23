using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.Carts;
using Xunit;
using static commercetools.Api.IntegrationTests.Cart.CartFixture;

namespace commercetools.Api.IntegrationTests.Cart
{
    [Collection("Integration Tests")]
    public class CartIntegrationTests
    {
        private readonly IClient _client;
        private readonly string _projectKey;

        public CartIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            var clientConfiguration = serviceProviderFixture.GetClientConfiguration("Client");
            this._client = serviceProviderFixture.GetService<IClient>();
            this._projectKey = clientConfiguration.ProjectKey;
        }

        [Fact]
        public async Task CreateCart()
        {
            var key = $"CreateCart-{TestingUtility.RandomString()}";
            await WithCart(
                _client,
                cartDraft => DefaultCartDraftWithKey(cartDraft, key),
                cart => { Assert.Equal(key, cart.Key); }
            );
        }

        [Fact]
        public async Task GetCartById()
        {
            var key = $"GetCartById-{TestingUtility.RandomString()}";
            await WithCart(
                _client, cartDraft => DefaultCartDraftWithKey(cartDraft, key),
                async cart =>
                {
                    Assert.NotNull(cart);
                    var retrievedCart = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .Carts()
                        .WithId(cart.Id)
                        .Get()
                        .ExecuteAsync();

                    Assert.NotNull(retrievedCart);
                    Assert.Equal(key, retrievedCart.Key);
                });
        }

        [Fact]
        public async Task GetCartByKey()
        {
            var key = $"GetCartByKey-{TestingUtility.RandomString()}";
            await WithCart(
                _client, cartDraft => DefaultCartDraftWithKey(cartDraft, key),
                async cart =>
                {
                    Assert.NotNull(cart);
                    var retrievedCart = await _client
                        .WithApi(_projectKey)
                        .Carts()
                        .WithKey(cart.Key)
                        .Get()
                        .ExecuteAsync();

                    Assert.NotNull(retrievedCart);
                    Assert.Equal(key, retrievedCart.Key);
                }
            );
        }

        [Fact]
        public async Task QueryCarts()
        {
            var key = $"QueryCarts-{TestingUtility.RandomString()}";
            await WithCart(
                _client, cartDraft => DefaultCartDraftWithKey(cartDraft, key),
                async cart =>
                {
                    Assert.NotNull(cart);
                    var returnedSet = await _client.WithApi().WithProjectKey(_projectKey)
                        .Carts()
                        .Get()
                        .WithQuery(q => q.Key().Is(cart.Key))
                        .ExecuteAsync();
                    Assert.Single(returnedSet.Results);
                    Assert.Equal(key, returnedSet.Results[0].Key);
                }
            );
        }

        [Fact]
        public async Task DeleteCartById()
        {
            var key = $"DeleteCartById-{TestingUtility.RandomString()}";
            await WithCart(
                _client, cartDraft => DefaultCartDraftWithKey(cartDraft, key),
                async cart =>
                {
                    Assert.NotNull(cart);

                    await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .Carts()
                        .WithId(cart.Id)
                        .Delete()
                        .WithVersion(cart.Version)
                        .ExecuteAsync();

                    await Assert.ThrowsAsync<NotFoundException>(
                        () => _client
                            .WithApi()
                            .WithProjectKey(_projectKey)
                            .Categories().WithId(cart.Id)
                            .Get()
                            .ExecuteAsync()
                    );
                }
            );
        }

        [Fact]
        public async Task DeleteCartByKey()
        {
            var key = $"DeleteCartByKey-{TestingUtility.RandomString()}";
            await WithCart(
                _client, cartDraft => DefaultCartDraftWithKey(cartDraft, key),
                async cart =>
                {
                    Assert.NotNull(cart);

                    await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .Carts()
                        .WithKey(cart.Key)
                        .Delete()
                        .WithVersion(cart.Version)
                        .ExecuteAsync();

                    await Assert.ThrowsAsync<NotFoundException>(
                        () => _client
                            .WithApi()
                            .WithProjectKey(_projectKey)
                            .Carts()
                            .WithId(cart.Id)
                            .Get()
                            .ExecuteAsync()
                    );
                }
            );
        }

        [Fact]
        public async Task UpdateCartByIdChangeCountry()
        {
            await WithUpdateableCart(_client, async cart =>
            {
                Assert.NotNull(cart);

                const string name = "US";
                var action = new CartSetCountryAction()
                {
                    Action = "setCountry",
                    Country = name
                };

                var update = new CartUpdate()
                {
                    Version = cart.Version,
                    Actions = new List<ICartUpdateAction>() { action }
                };

                try
                {
                    var updatedCart = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .Carts()
                        .WithId(cart.Id)
                        .Post(update)
                        .ExecuteAsync();

                    Assert.Equal(name, updatedCart.Country);
                    return updatedCart;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            });
        }
    }
}