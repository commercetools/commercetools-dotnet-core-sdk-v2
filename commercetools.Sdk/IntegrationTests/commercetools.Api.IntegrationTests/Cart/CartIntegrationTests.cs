using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using commercetools.Sdk.GraphQL.Api;
using Xunit;
using static commercetools.Api.IntegrationTests.Cart.CartFixture;
using static commercetools.Api.IntegrationTests.Type.TypeFixtures;
using CartDraft = commercetools.Sdk.Api.Models.Carts.CartDraft;
using CustomFieldsDraft = commercetools.Sdk.Api.Models.Types.CustomFieldsDraft;
using FieldDefinition = commercetools.Sdk.Api.Models.Types.FieldDefinition;
using LocalizedString = commercetools.Sdk.Api.Models.Common.LocalizedString;
using Money = commercetools.Sdk.Api.Models.Common.Money;

namespace commercetools.Api.IntegrationTests.Cart
{
    [Collection("Integration Tests")]
    public class CartIntegrationTests
    {
        private readonly ProjectApiRoot _client;

        public CartIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._client = serviceProviderFixture.GetService<ProjectApiRoot>();
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
                    var returnedSet = await _client
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
                        .Carts()
                        .WithId(cart.Id)
                        .Delete()
                        .WithVersion(cart.Version)
                        .ExecuteAsync();

                    await Assert.ThrowsAsync<NotFoundException>(
                        () => _client
                            .Carts().WithId(cart.Id)
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
                        .Carts()
                        .WithKey(cart.Key)
                        .Delete()
                        .WithVersion(cart.Version)
                        .ExecuteAsync();

                    await Assert.ThrowsAsync<NotFoundException>(
                        () => _client
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

        [Fact]
        public async Task TestMoney()
        {
            var gqlClient = _client.GraphQLClient();
            var key = $"GetTypeById-{TestingUtility.RandomString()}";
            await WithType(_client, typeDraft =>
            {
                var draft = DefaultTypeDraftWithKey(typeDraft, key);
                draft.FieldDefinitions = new List<IFieldDefinition>()
                {
                    new FieldDefinition()
                    {
                        Type = new CustomFieldMoneyType()
                        {
                        },
                        Label = new LocalizedString()
                        {
                            { "en", "money" }
                        },
                        Required = false,
                        Name = "money"
                    }
                };
                return draft;
            }, async type =>
            {
                await WithCart(_client, draft =>
                {
                    draft.Currency = "EUR";
                    draft.Custom = new CustomFieldsDraft()
                    {
                        Type = new TypeResourceIdentifier() { Key = type.Key },
                        Fields = new FieldContainer()
                        {
                            { "money", new MoneyDraft() { CurrencyCode = "EUR", CentAmount = 100 } }
                        }
                    };
                    return draft;
                }, async cart =>
                {
                    var retrieveCart = await _client.Carts().WithId(cart.Id).Get().ExecuteAsync();
                    Assert.IsAssignableFrom<IMoney>(retrieveCart.Custom.Fields["money"]);
                    var cartId = cart.Id;
                    var t = await gqlClient.Query(o => o.Cart(id: cartId, selector: cart => new { Custom = cart.Custom(custom => new { Field = custom.CustomFieldsRaw(selector: field => field.Value) }) }));
                    Assert.NotNull(t);
                });
            });
        }
    }
}