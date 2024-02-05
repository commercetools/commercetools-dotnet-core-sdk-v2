using System;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.CustomObjects;
using Xunit;
using static commercetools.Api.IntegrationTests.CustomObject.CustomObjectFixtures;

namespace commercetools.Api.IntegrationTests.CustomObject
{
    [Collection("Integration Tests")]
    public class CustomObjectIntegrationTests
    {
        private readonly IClient _client;
        private readonly string _projectKey;

        public CustomObjectIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            var clientConfiguration = serviceProviderFixture.GetClientConfiguration("Client");
            this._client = serviceProviderFixture.GetService<IClient>();
            this._projectKey = clientConfiguration.ProjectKey;
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
                        .WithApi()
                        .WithProjectKey(_projectKey)
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
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .CustomObjects()
                        .Get()
                        .WithQuery(q => q.Key().Is(customer.Key))
                        .ExecuteAsync();

                    Assert.Single(returnedSet.Results);
                    Assert.Equal(key, returnedSet.Results[0].Key);
                });
        }

        [Fact]
        public async Task UpdateCustomObjectByIdChangeFirstName()
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
                            .WithApi()
                            .WithProjectKey(_projectKey)
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
    }
}