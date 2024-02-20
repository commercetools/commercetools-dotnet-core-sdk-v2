using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Errors;
using Xunit;
using static commercetools.Api.IntegrationTests.Customers.CustomersFixtures;

namespace commercetools.Api.IntegrationTests.Customers
{
    [Collection("Integration Tests")]
    public class CustomerIntegrationTests
    {
        private readonly ProjectApiRoot _client;
        private readonly string _projectKey;

        public CustomerIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._client = serviceProviderFixture.GetService<ProjectApiRoot>();
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
                        .Customers()
                        .WithId(customer.Id)
                        .Post(update)
                        .ExecuteAsync();

                    Assert.Equal(updatedCustomer.FirstName, name);
                    return updatedCustomer;
                }
            );
        }
        
        [Fact]
        public async Task LoginFails()
        {
            await WithCustomer(
                _client,
                DefaultCustomerDraft,
                async customer =>
                {
                    var exception = await Assert.ThrowsAsync<BadRequestException>(async () =>
                    {
                        await _client
                            .Login()
                            .Post(new CustomerSignin()
                            {
                                Email = customer.Email,
                                Password = "abcdef"
                            })
                            .ExecuteAsync();
                    });
                    var response = exception.AsErrorResponse();
                    Assert.NotNull(response);
                    Assert.True(response.HasErrorCode(IErrorObject.InvalidCredentials().Code));
                    Assert.IsAssignableFrom<IInvalidCredentialsError>(response.Errors.First());
                    Assert.Equal(IErrorObject.InvalidCredentials().Code, response.Errors.First().Code);
                }
            );
        }
    }
}