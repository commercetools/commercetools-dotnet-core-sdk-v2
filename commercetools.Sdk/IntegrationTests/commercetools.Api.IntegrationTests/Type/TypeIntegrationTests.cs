using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using Xunit;
using static commercetools.Api.IntegrationTests.Type.TypeFixtures;

namespace commercetools.Api.IntegrationTests.Type
{
    [Collection("Integration Tests")]
    public class TypeIntegrationTests
    {
        private readonly ProjectApiRoot _client;

        public TypeIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._client = serviceProviderFixture.GetService<ProjectApiRoot>();
        }

        [Fact]
        public async Task CreateType()
        {
            var key = $"CreateType-{TestingUtility.RandomString()}";
            await WithType(
                _client, typeDraft => DefaultTypeDraftWithKey(typeDraft, key),
                type => { Assert.Equal(key, type.Key); }
            );
        }

        [Fact]
        public async Task GetTypeById()
        {
            var key = $"GetTypeById-{TestingUtility.RandomString()}";
            await WithType(
                _client,
                typeDraft => DefaultTypeDraftWithKey(typeDraft, key),
                async type =>
                {
                    Assert.NotNull(type);
                    var retrievedType = await _client
                        .Types()
                        .WithId(type.Id)
                        .Get()
                        .ExecuteAsync();

                    Assert.NotNull(retrievedType);
                    Assert.Equal(key, retrievedType.Key);
                }
            );
        }

        [Fact]
        public async Task QueryType()
        {
            var key = $"QueryType-{TestingUtility.RandomString()}";
            await WithType(
                _client,
                typeDraft => DefaultTypeDraftWithKey(typeDraft, key),
                async type =>
                {
                    Assert.NotNull(type);
                    var returnedSet = await _client
                        .Types()
                        .Get()
                        .WithQuery(q => q.Key().Is(type.Key))
                        .ExecuteAsync();

                    Assert.Single(returnedSet.Results);
                    Assert.Equal(key, returnedSet.Results[0].Key);
                });
        }

        [Fact]
        public async Task UpdateTypeByIdChangeDescription()
        {
            await WithUpdateableType(
                _client,
                async type =>
                {
                    Assert.NotNull(type);
                    var name = $"Test-Desc-{TestingUtility.RandomString()}";
                    var action = new TypeSetDescriptionAction()
                    {
                        Action = "setDescription",
                        Description = new LocalizedString() { { "en", name } }
                    };

                    var update = new TypeUpdate()
                    {
                        Version = type.Version,
                        Actions = new List<ITypeUpdateAction>() { action }
                    };

                    var updatedType = await _client
                        .Types()
                        .WithId(type.Id)
                        .Post(update)
                        .ExecuteAsync();

                    Assert.Equal(updatedType.Description, new LocalizedString() { { "en", name } });
                    return updatedType;
                }
            );
        }
    }
}