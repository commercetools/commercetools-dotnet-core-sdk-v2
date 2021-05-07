using System;
using System.Threading.Tasks;
using commercetools.Api.Models.Customers;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api.Extensions;

namespace commercetools.Api.IntegrationTests
{
    public class CustomerServices
    {
        public const string CUSTOMER_EMAIL = "Customer_Me@gmail.com";
        public const string CUSTOMER_PASSWORD = "password";
        public const string CUSTOMER_KEY = "Customer_Me_Key123";
        public async Task<ICustomer> GetCustomerByKey(IClient adminClient,string key)
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
        public async Task<ICustomer> CreateCustomer(IClient adminClient,CustomerDraft customerDraft)
        {
            var customerSignInResult = await adminClient.WithApi().WithProjectKey(GenericFixture.DefaultProjectKey)
                .Customers()
                .Post(customerDraft)
                .ExecuteAsync();
            var customer = customerSignInResult.Customer;
            return customer;
        }
    }
}