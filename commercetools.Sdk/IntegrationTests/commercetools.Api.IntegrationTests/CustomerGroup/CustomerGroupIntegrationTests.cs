using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.CustomerGroups;
using Xunit;
using static commercetools.Api.IntegrationTests.CustomerGroup.CustomerGroupFixtures;

namespace commercetools.Api.IntegrationTests.CustomerGroup
{
    [Collection("Integration Tests")]
    public class CustomerIntegrationTests
    {
        private readonly ProjectApiRoot _client;

        public CustomerIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._client = serviceProviderFixture.GetService<ProjectApiRoot>();
        }

        [Fact]
        public async Task CreateCustomerGroup()
        {
            var key = $"CreateCustomer-{TestingUtility.RandomString()}";
            await WithCustomerGroup(
                _client,
                customerGroupDraft => DefaultCustomerGroupDraftWithKey(customerGroupDraft, key),
                customerGroup => { Assert.Equal(key, customerGroup.Key); }
            );
        }

        [Fact]
        public async Task GetCustomerGroupById()
        {
            var key = $"GetCustomerById-{TestingUtility.RandomString()}";
            await WithCustomerGroup(
                _client,
                customerDraft => DefaultCustomerGroupDraftWithKey(customerDraft, key),
                async customerGroup =>
                {
                    Assert.NotNull(customerGroup);
                    var retrievedCustomer = await _client
                        .CustomerGroups()
                        .WithId(customerGroup.Id)
                        .Get()
                        .ExecuteAsync();

                    Assert.NotNull(retrievedCustomer);
                    Assert.Equal(key, retrievedCustomer.Key);
                }
            );
        }

        [Fact]
        public async Task QueryCustomersGroup()
        {
            var key = $"QueryCustomers-{TestingUtility.RandomString()}";
            await WithCustomerGroup(
                _client,
                customerDraft => DefaultCustomerGroupDraftWithKey(customerDraft, key),
                async customerGroup =>
                {
                    Assert.NotNull(customerGroup);
                    var returnedSet = await _client
                        .CustomerGroups()
                        .Get()
                        .WithQuery(q => q.Key().Is(customerGroup.Key))
                        .ExecuteAsync();

                    Assert.Single(returnedSet.Results);
                    Assert.Equal(key, returnedSet.Results[0].Key);
                });
        }

        [Fact]
        public async Task UpdateCustomerGroupByIdChangeKey()
        {
            await WithUpdateableCustomerGroup(
                _client,
                async customerGroup =>
                {
                    Assert.NotNull(customerGroup);
                    var name = $"{TestingUtility.RandomString()}";
                    var action = new CustomerGroupSetKeyAction()
                    {
                        Action = "setKey",
                        Key = name
                    };

                    var update = new CustomerGroupUpdate()
                    {
                        Version = customerGroup.Version,
                        Actions = new List<ICustomerGroupUpdateAction>() { action }
                    };

                    var updatedCustomerGroup = await _client
                        .CustomerGroups()
                        .WithId(customerGroup.Id)
                        .Post(update)
                        .ExecuteAsync();

                    Assert.Equal(updatedCustomerGroup.Key, name);
                    return updatedCustomerGroup;
                }
            );
        }
    }
}