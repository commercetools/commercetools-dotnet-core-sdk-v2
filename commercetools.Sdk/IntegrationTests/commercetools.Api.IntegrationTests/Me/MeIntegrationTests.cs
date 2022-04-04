using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Api.IntegrationTests.Services;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.ShoppingLists;
using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Serialization;
using Xunit;

namespace commercetools.Api.IntegrationTests.Me
{
    [Collection("Integration Tests")]
    public class MeIntegrationTests
    {
        #region Fields

        private readonly IClient _adminClient;
        private readonly CustomerServices _customerServices;
        private readonly ShoppingListServices _shoppingListServices;
        private readonly ServiceProviderFixture _serviceProviderFixture;
        private IClient _meClient;
        private ICustomer _customer = null;

        #endregion

        public MeIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._serviceProviderFixture = serviceProviderFixture;
            this._adminClient = serviceProviderFixture.GetService<IClient>();
            _customerServices = new CustomerServices();
            _shoppingListServices = new ShoppingListServices();
            CreateMeClient();
        }

        [Fact]
        public async Task GetMyProfile()
        {
            //Arrange
            await CreateEntitiesForTesting();

            //Act
            var myProfile = await _meClient.WithApi()
                .WithProjectKey(GenericFixture.DefaultProjectKey)
                .Me()
                .Get()
                .ExecuteAsync();

            //Assert
            Assert.NotNull(myProfile);
            Assert.Equal(CustomerServices.CustomerEmail, myProfile.Email);
        }

        [Fact]
        public async Task GetMyShoppingLists()
        {
            //Arrange
            await CreateEntitiesForTesting();

            //Act
            var response = await _meClient.WithApi()
                .WithProjectKey(GenericFixture.DefaultProjectKey)
                .Me()
                .ShoppingLists()
                .Get()
                .ExecuteAsync();

            //Assert
            var shoppingList = response.Results.FirstOrDefault();
            Assert.NotNull(shoppingList);
            Assert.Equal(ShoppingListServices.ShoppingListKey, shoppingList.Key);
        }

        private async Task CreateEntitiesForTesting()
        {
            //Get Customer By Key, Create if not exists
            _customer = await _customerServices.GetCustomerByKey(_adminClient, CustomerServices.CustomerKey);
            if (_customer == null)
            {
                var customerDraft = _customerServices.CreateCustomerDraft();
                _customer = await _customerServices.CreateCustomer(_adminClient, customerDraft);
            }

            //Create a shoppingList for this customer (if not exists)
            IShoppingList shoppingList =
                await _shoppingListServices.GetShoppingListByKey(_adminClient, ShoppingListServices.ShoppingListKey);
            if (shoppingList == null)
            {
                var shoppingListDraft = _shoppingListServices.CreateShoppingListDraft(
                    new CustomerResourceIdentifier()
                    {
                        Id = _customer.Id
                    });
                shoppingList = await _shoppingListServices
                    .CreateShoppingList(_adminClient, shoppingListDraft);
            }
        }

        private void CreateMeClient()
        {
            var meClientConfig = _serviceProviderFixture.GetClientConfiguration("MeClient");
            var httpClientFactory = _serviceProviderFixture.GetService<IHttpClientFactory>();
            var serializerService = _serviceProviderFixture.GetService<SerializerService>();

            //Create passwordFlow TokenProvider
            var passwordTokenProvider = TokenProviderFactory
                .CreatePasswordTokenProvider(meClientConfig,
                    httpClientFactory,
                    new InMemoryUserCredentialsStoreManager(
                        CustomerServices.CustomerEmail,
                        CustomerServices.CustomerPassword));

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