using System.Threading.Tasks;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api.Extensions;

namespace commercetools.Sdk.Api.IntegrationTests.Services
{
    public class CustomerServices
    {
        public const string CustomerEmail = "Customer_Me@gmail.com";
        public const string CustomerPassword = "password";
        public const string CustomerKey = "Customer_Me_Key123";
        public async Task<ICustomer> GetCustomerByKey(IClient adminClient, string key)
        {
            try
            {
                var customer = await adminClient.WithApi().WithProjectKey(GenericFixture.DefaultProjectKey)
                    .Customers()
                    .WithKey(key)
                    .Get()
                    .ExecuteAsync();
                return customer;
            }
            catch (NotFoundException)
            {
                // ignored
            }

            return null;
        }
        public async Task<ICustomer> CreateCustomer(IClient adminClient, ICustomerDraft customerDraft)
        {
            var customerSignInResult = await adminClient.WithApi().WithProjectKey(GenericFixture.DefaultProjectKey)
                .Customers()
                .Post(customerDraft)
                .ExecuteAsync();
            var customer = customerSignInResult.Customer;
            return customer;
        }

        public ICustomerDraft CreateCustomerDraft()
        {
            return new CustomerDraft
            {
                Email = CustomerEmail,
                Password = CustomerPassword,
                Key = CustomerKey,
                FirstName = "FN_Me",
                LastName = "LN_Me"
            };
        }
    }
}