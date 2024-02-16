using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.Customers;
using static commercetools.Api.IntegrationTests.GenericFixture;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.Common;

namespace commercetools.Api.IntegrationTests.Customers
{
    public class CustomersFixtures
    {
        #region DraftBuilds

        public static CustomerDraft DefaultCustomerDraft(CustomerDraft customerDraft)
        {
            var randomInt = TestingUtility.RandomInt();
            var randomStr = TestingUtility.RandomString();
            customerDraft.Email = $"test-{randomStr}@mail.com";
            customerDraft.FirstName = "test-first-name";
            customerDraft.LastName = "test-last-name";
            customerDraft.Password = $"test-password-{randomStr}";
            
            // customerDraft.Addresses = new List<IBaseAddress>()
            // {
            //   new BaseAddress() { Country = "DE", Key = $"Key{randomInt}" }
            // };

            return customerDraft;
        }

        #endregion

        public static CustomerDraft DefaultCustomerDraftWithKey(CustomerDraft draft, string key)
        {
            var customerDraft = DefaultCustomerDraft(draft);
            customerDraft.Key = key;

            return customerDraft;
        }
        
        public static async Task<ICustomer> CreateCustomer(ProjectApiRoot client, CustomerDraft customerDraft)
        {
            try
            {
                return await client
                    .Customers()
                    .Post(customerDraft)
                    .ExecuteAsync()
                    .ContinueWith(r => r.Result.Customer);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static async Task DeleteCustomer(ProjectApiRoot client, ICustomer customer)
        {
            try
            {
                await client
                    .Customers()
                    .WithKey(customer.Key)
                    .Delete()
                    .WithVersion(customer.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #region

        public static async Task WithCustomer(ProjectApiRoot client, Func<CustomerDraft, CustomerDraft> draftAction,
            Action<ICustomer> func)
        {
            await With(client, new CustomerDraft(), draftAction, func, CreateCustomer, DeleteCustomer);
        }

        public static async Task WithCustomer(ProjectApiRoot client, Func<CustomerDraft, CustomerDraft> draftAction,
            Func<ICustomer, Task> func)
        {
            await WithAsync(client, new CustomerDraft(), draftAction, func, CreateCustomer, DeleteCustomer);
        }

        public static async Task WithCart(ProjectApiRoot client, Func<ICustomer, Task> func)
        {
            await WithAsync(client, new CustomerDraft(), DefaultCustomerDraft, func, CreateCustomer, DeleteCustomer);
        }

        public static async Task WithUpdateableCustomer(ProjectApiRoot client, Func<ICustomer, Task<ICustomer>> func)
        {
            await WithUpdateableAsync(client, new CustomerDraft(), DefaultCustomerDraft, func, CreateCustomer,
                DeleteCustomer);
        }

        #endregion
    }
}