using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Stores;
using Xunit;
using static commercetools.Api.IntegrationTests.Store.StoreFixtures;

namespace commercetools.Api.IntegrationTests.Store
{
    [Collection("Integration Tests")]
    public class StoreIntegrationTests
    {
        private readonly ProjectApiRoot _client;

        public StoreIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._client = serviceProviderFixture.GetService<ProjectApiRoot>();
        }

        [Fact]
        public async Task CreateStore()
        {
            var key = $"CreateStore-{TestingUtility.RandomString()}";
            await WithStore(
                _client, storeDraft => DefaultStoreDraftWithKey(storeDraft, key),
                store => { Assert.Equal(key, store.Key); }
            );
        }

        [Fact]
        public async Task GetStoreById()
        {
            var key = $"GetStoreById-{TestingUtility.RandomString()}";
            await WithStore(
                _client,
                storeDraft => DefaultStoreDraftWithKey(storeDraft, key),
                async store =>
                {
                    Assert.NotNull(store);
                    var retrievedStore = await _client
                        .Stores()
                        .WithId(store.Id)
                        .Get()
                        .ExecuteAsync();

                    Assert.NotNull(retrievedStore);
                    Assert.Equal(key, retrievedStore.Key);
                }
            );
        }

        [Fact]
        public async Task QueryStore()
        {
            var key = $"QueryStore-{TestingUtility.RandomString()}";
            await WithStore(
                _client,
                storeDraft => DefaultStoreDraftWithKey(storeDraft, key),
                async store =>
                {
                    Assert.NotNull(store);
                    var returnedSet = await _client
                        .Stores()
                        .WithKey(key)
                        .Get()
                        .ExecuteAsync();

                    Assert.Equal(key, returnedSet.Key);
                });
        }

        [Fact]
        public async Task UpdateStoreByIdChangeDescription()
        {
            await WithUpdateableStore(
                _client,
                async store =>
                {
                    Assert.NotNull(store);
                    var name = $"Test-Desc-{TestingUtility.RandomString()}";
                    var action = new StoreSetNameAction()
                    {
                        Action = "setName",
                        Name = new LocalizedString() { { "en", name } }
                    };

                    var update = new StoreUpdate()
                    {
                        Version = store.Version,
                        Actions = new List<IStoreUpdateAction>() { action }
                    };

                    var updatedStore = await _client
                        .Stores()
                        .WithId(store.Id)
                        .Post(update)
                        .ExecuteAsync();

                    Assert.Equal(updatedStore.Name, new LocalizedString() { { "en", name } });
                    return updatedStore;
                }
            );
        }
    }
}