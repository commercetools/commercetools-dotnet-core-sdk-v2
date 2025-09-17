using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.CustomObjects;
using Xunit;
using static commercetools.Api.IntegrationTests.CustomObject.CustomObjectFixtures;

namespace commercetools.Api.IntegrationTests.CustomObject
{
    public class Foo
    {

        public List<Bar> Bars { get; set; }

        public Foo()
        {
        }
    }

    public class Bar
    {
        public long Number { get; set; }
        public string Name { get; set; }
    }

    [Collection("Integration Tests")]
    public class CustomObjectIntegrationTests
    {
        private readonly ProjectApiRoot _client;

        public CustomObjectIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._client = serviceProviderFixture.GetService<ProjectApiRoot>();
        }

        [Fact]
        public async Task CreateCustomObject()
        {
            var key = $"CreateCustomObject-{TestingUtility.RandomString()}";
            await WithCustomObject(
                _client,
                customObjectDraft => DefaultCustomObjectDraftWithKey(customObjectDraft, key),
                customer => { Assert.Equal(key, customer.Key); }
            );
        }

        [Fact]
        public async Task GetCustomObjectById()
        {
            var key = $"GetCustomObjectById-{TestingUtility.RandomString()}";
            await WithCustomObject(
                _client,
                customObjectDraft => DefaultCustomObjectDraftWithKey(customObjectDraft, key),
                async customObject =>
                {
                    Assert.NotNull(customObject);
                    var retrievedCustomObject = await _client
                        .CustomObjects()
                        .WithContainerAndKey(customObject.Container, customObject.Key)
                        .Get()
                        .ExecuteAsync();

                    Assert.NotNull(retrievedCustomObject);
                    Assert.Equal(key, retrievedCustomObject.Key);
                }
            );
        }

        [Fact]
        public async Task QueryCustomObject()
        {
            var key = $"QueryCustomObjects-{TestingUtility.RandomString()}";
            await WithCustomObject(
                _client,
                customerDraft => DefaultCustomObjectDraftWithKey(customerDraft, key),
                async customer =>
                {
                    Assert.NotNull(customer);
                    var returnedSet = await _client
                        .CustomObjects()
                        .Get()
                        .WithQuery(q => q.Key().Is(customer.Key))
                        .ExecuteAsync();

                    Assert.Single(returnedSet.Results);
                    Assert.Equal(key, returnedSet.Results[0].Key);
                });
        }

        [Fact]
        public async Task UpdateCustomObjectById()
        {
            await WithUpdateableCustomObject(
                _client,
                async customObject =>
                {
                    try
                    {
                        Assert.NotNull(customObject);
                        var name = $"New-Custom-Object-Value-{TestingUtility.RandomString()}";

                        var update = new CustomObjectDraft()
                        {
                            Key = customObject.Key,
                            Container = customObject.Container,
                            Value = name
                        };

                        var updatedCustomObject = await _client
                            .CustomObjects()
                            .Post(update)
                            .ExecuteAsync();

                        Assert.Equal(updatedCustomObject.Key, customObject.Key);
                        return updatedCustomObject;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }
            );
        }

        [Fact]
        public async Task updateWithGenericClass()
        {
            await WithUpdateableCustomObject(
                _client,
                async customObject =>
                {
                    Foo foo = new Foo()
                    {
                        Bars = new List<Bar>()
                    {
                        new() { Number = 1, Name = "World's End"},
                        new() { Number = 2, Name = "Winchester"}
                    }
                    };

                    CustomObjectDraft customObjectDraft = new CustomObjectDraft()
                    {
                        Container = customObject.Container,
                        Key = customObject.Key,
                        Value = foo
                    };

                    GenericCustomObject<Foo> typeRefCustomObject = await _client
                            .CustomObjects()
                            .Post(customObjectDraft)
                            .ExecuteAsync<Foo>();

                    Assert.NotNull(typeRefCustomObject);
                    Assert.Equal("World's End", typeRefCustomObject.Value.Bars[0].Name);
                    Assert.Equal(1, typeRefCustomObject.Value.Bars[0].Number);
                    Assert.Equal("Winchester", typeRefCustomObject.Value.Bars[1].Name);
                    Assert.Equal(2, typeRefCustomObject.Value.Bars[1].Number);

                    var queryResult = await _client
                        .CustomObjects()
                        .WithContainer(customObject.Container)
                        .Get()
                        .ExecuteAsync<Foo>();
                    Assert.NotNull(queryResult);
                    Assert.Equal("World's End", queryResult.Results[0].Value.Bars[0].Name);

                    var getResult = await _client
                        .CustomObjects()
                        .WithContainerAndKey(customObject.Container, customObject.Key)
                        .Get()
                        .ExecuteAsync<Foo>();
                    Assert.NotNull(getResult);
                    Assert.Equal("World's End", getResult.Value.Bars[0].Name);


                    var queryGeneralResult = await _client
                        .CustomObjects()
                        .Get()
                        .WithQuery(q => q.Container().Is(customObject.Container))
                        .ExecuteAsync<Foo>();
                    Assert.NotNull(queryGeneralResult);
                    Assert.Equal("World's End", queryGeneralResult.Results[0].Value.Bars[0].Name);

                    return customObject;
                });
        }
    }
}