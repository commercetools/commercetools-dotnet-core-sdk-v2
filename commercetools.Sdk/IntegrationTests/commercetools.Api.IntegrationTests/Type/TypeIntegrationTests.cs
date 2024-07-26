using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using commercetools.Sdk.GraphQL.Api;
using Xunit;
using static commercetools.Api.IntegrationTests.Type.TypeFixtures;
using static commercetools.Api.IntegrationTests.Cart.CartFixture;
using CustomFieldsDraft = commercetools.Sdk.Api.Models.Types.CustomFieldsDraft;
using FieldDefinition = commercetools.Sdk.Api.Models.Types.FieldDefinition;
using FieldType = commercetools.Sdk.Api.Models.Types.FieldType;
using LocalizedString = commercetools.Sdk.Api.Models.Common.LocalizedString;

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
        public async Task CartWithCustomType()
        {
            var gqlClient = _client.GraphQLClient();

            var key = $"QueryType-{TestingUtility.RandomString()}";
            
            await WithType(
                _client,
                typeDraft =>
                {
                    var draft = DefaultTypeDraftWithKey(typeDraft, key);
                    draft.FieldDefinitions = new List<IFieldDefinition>()
                    {
                        new FieldDefinition()
                        {
                            Type = new CustomFieldStringType()
                            {
                            },
                            Label = new LocalizedString()
                            {
                                {"en", "test-string"}
                            },
                            Required = false,
                            Name = "test-string"
                        },
                        new FieldDefinition()
                        {
                            Type = new CustomFieldSetType()
                            {
                                ElementType = new CustomFieldStringType()
                            },
                            Label = new LocalizedString()
                            {
                                {"en", "test-set"}
                            },
                            Required = false,
                            Name = "test-set"
                        }
                    };
                    return draft;
                },
                async type =>
                {
                    await WithCart(_client, cartDraft =>
                    {
                        var draft = DefaultCartDraft(cartDraft);
                        draft.Custom = new CustomFieldsDraft()
                        {
                            Type = new TypeResourceIdentifier() { Key = type.Key },
                            Fields = new FieldContainer()
                            {
                                { "test-set", new List<string>()
                                    {
                                    "abc",
                                    "def"
                                    }
                                },
                                { "test-string", "foo"
                            }
                            }
                        };
                        return draft;
                    }, async cart =>
                    {
                        var cartId = cart.Id;
                        var t = await gqlClient.Query(o => o.Cart(id: cartId, selector: cart => new { Custom = cart.Custom(custom => new { Field = custom.CustomFieldsRaw(selector: field => field.Value) })}));
                        Assert.Equal("abc", t.Data.Custom.Field[0].Deserialize<List<string>>()[0]);
                        Assert.Equal("def", t.Data.Custom.Field[0].Deserialize<List<string>>()[1]);
                        Assert.Equal("foo", t.Data.Custom.Field[1].ToString());
                    });
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