using System;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Api.Models.Customers;
using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Serialization;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace commercetools.Api.IntegrationTests.Me
{
    [Collection("Integration Tests")]
    public class MeIntegrationTests
    {
        #region Fields

        private readonly IClient _adminClient;
        private readonly CustomerServices _customerServices;
        private readonly ServiceProviderFixture _serviceProviderFixture;
        private IClient _meClient;
        private ICustomer _customer = null;

        #endregion

        public MeIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._serviceProviderFixture = serviceProviderFixture;
            this._adminClient = serviceProviderFixture.GetService<IClient>();
            _customerServices = new CustomerServices();
        }

        [Fact]
        public async Task GetMyProfile()
        {
            //Arrange
            await CreateEntitiesForTesting();
            CreateMeClient();

            //Act
            var myProfile = await _meClient.WithApi()
                .WithProjectKey(GenericFixture.DefaultProjectKey)
                .Me()
                .Get()
                .ExecuteAsync();

            //Assert
            Assert.NotNull(myProfile);
            Assert.Equal(CustomerServices.CUSTOMER_EMAIL, myProfile.Email);
        }

        private async Task CreateEntitiesForTesting()
        {
            //Get Customer By Key, Create if not exists
            _customer = await _customerServices.GetCustomerByKey(_adminClient, CustomerServices.CUSTOMER_KEY);
            if (_customer == null)
            {
                var customerDraft = new CustomerDraft
                {
                    Email = CustomerServices.CUSTOMER_EMAIL,
                    Password = CustomerServices.CUSTOMER_PASSWORD,
                    Key = CustomerServices.CUSTOMER_KEY,
                    FirstName = "FN_Me",
                    LastName = "LN_Me"
                };
                _customer = await _customerServices.CreateCustomer(_adminClient, customerDraft);
            }
        }

        private void CreateMeClient()
        {
            var meClientConfig= _serviceProviderFixture.GetClientConfiguration("MeClient");
            var httpClientFactory = _serviceProviderFixture.GetService<IHttpClientFactory>();
            var serializerService = _serviceProviderFixture.GetService<SerializerService>();

            //Create passwordFlow TokenProvider
            var passwordTokenProvider = TokenProviderFactory
                .CreatePasswordTokenProvider(meClientConfig,
                    httpClientFactory,
                    new InMemoryUserCredentialsStoreManager(
                        CustomerServices.CUSTOMER_EMAIL,
                        CustomerServices.CUSTOMER_PASSWORD));

            //Create MeClient
            _meClient = ClientFactory.Create(
                "MeClient",
                meClientConfig,
                httpClientFactory,
                serializerService,
                passwordTokenProvider);
        }
    }
}