using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Customers;
using Xunit;
using static commercetools.Api.IntegrationTests.Customers.CustomerFixtures;

namespace commercetools.Api.IntegrationTests.Customers
{
    [Collection("Integration Tests")]
    public class CustomerIntegrationTests
    {
        private readonly IClient _client;
        private readonly string _projectKey;

        public CustomerIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            var clientConfiguration = serviceProviderFixture.GetClientConfiguration("Client");
            this._client = serviceProviderFixture.GetService<IClient>();
            this._projectKey = clientConfiguration.ProjectKey;
        }

        [Fact]
        public async Task CreateCustomer()
        {
            var key = $"CreateCustomer-{TestingUtility.RandomString()}";
            await WithCustomer(
                _client,
                customerDraft => DefaultCustomerDraftWithKey(customerDraft, key),
                customer => { Assert.Equal(key, customer.Key); }
            );
        }

        [Fact]
        public async Task GetCustomerById()
        {
            var key = $"GetCustomerById-{TestingUtility.RandomString()}";
            await WithCustomer(
                _client,
                customerDraft => DefaultCustomerDraftWithKey(customerDraft, key),
                async customer =>
                {
                    Assert.NotNull(customer);
                    var retrievedCustomer = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .Customers()
                        .WithId(customer.Id)
                        .Get()
                        .ExecuteAsync();

                    Assert.NotNull(retrievedCustomer);
                    Assert.Equal(key, retrievedCustomer.Key);
                }
            );
        }

        [Fact]
        public async Task QueryCustomers()
        {
            var key = $"QueryCustomers-{TestingUtility.RandomString()}";
            await WithCustomer(
                _client,
                customerDraft => DefaultCustomerDraftWithKey(customerDraft, key),
                async customer =>
                {
                    Assert.NotNull(customer);
                    var returnedSet = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .Customers()
                        .Get()
                        .WithQuery(q => q.Key().Is(customer.Key))
                        .ExecuteAsync();

                    Assert.Single(returnedSet.Results);
                    Assert.Equal(key, returnedSet.Results[0].Key);
                });
        }

        [Fact]
        public async Task UpdateCustomerByIdChangeFirstName()
        {
            await WithUpdateableCustomer(
                _client,
                async customer =>
                {
                    Assert.NotNull(customer);
                    var name = $"{TestingUtility.RandomString()}";
                    var action = new CustomerSetFirstNameAction()
                    {
                        Action = "setFirstName",
                        FirstName = name
                    };

                    var update = new CustomerUpdate()
                    {
                        Version = customer.Version,
                        Actions = new List<ICustomerUpdateAction>() { action }
                    };

                    var updatedCustomer = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .Customers()
                        .WithId(customer.Id)
                        .Post(update)
                        .ExecuteAsync();

                    Assert.Equal(updatedCustomer.FirstName, name);
                    return updatedCustomer;
                }
            );
        }
    }
}