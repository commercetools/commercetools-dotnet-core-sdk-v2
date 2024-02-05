using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.CustomerGroups;
using static commercetools.Api.IntegrationTests.GenericFixture;

namespace commercetools.Api.IntegrationTests.CustomerGroup
{
    public class CustomerGroupFixtures
    {
        #region DraftBuilds

        public static CustomerGroupDraft DefaultCustomerGroupDraft(CustomerGroupDraft customerGroupsDraft)
        {
            var randomStr = TestingUtility.RandomString();
            customerGroupsDraft.GroupName = $"Test-name-customerGroup-{randomStr}";

            return customerGroupsDraft;
        }

        #endregion

        public static CustomerGroupDraft DefaultCustomerGroupDraftWithKey(CustomerGroupDraft draft, string key)
        {
            var customerGroupDraft = DefaultCustomerGroupDraft(draft);
            customerGroupDraft.Key = key;

            return customerGroupDraft;
        }

        // public static async Task<ICustomerSigninResult>
        public static async Task<ICustomerGroup> CreateCustomerGroup(IClient client, CustomerGroupDraft customerGroupsDraft)
        {
            try
            {
                return await client
                    .WithApi()
                    .WithProjectKey(DefaultProjectKey)
                    .CustomerGroups()
                    .Post(customerGroupsDraft)
                    .ExecuteAsync()
                    .ContinueWith(r => r.Result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static async Task DeleteCustomerGroup(IClient client, ICustomerGroup customerGroup)
        {
            try
            {
                await client
                    .WithApi()
                    .WithProjectKey(DefaultProjectKey)
                    .Customers()
                    .WithKey(customerGroup.Key)
                    .Delete()
                    .WithVersion(customerGroup.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #region

        public static async Task WithCustomerGroup(IClient client,
            Func<CustomerGroupDraft, CustomerGroupDraft> draftAction,
            Action<ICustomerGroup> func)
        {
            await With(client, new CustomerGroupDraft(), draftAction, func, CreateCustomerGroup, DeleteCustomerGroup);
        }

        public static async Task WithCustomerGroup(IClient client,
            Func<CustomerGroupDraft, CustomerGroupDraft> draftAction,
            Func<ICustomerGroup, Task> func)
        {
            await WithAsync(client, new CustomerGroupDraft(), draftAction, func, CreateCustomerGroup,
                DeleteCustomerGroup);
        }

        public static async Task WithUpdateableCustomerGroup(IClient client, Func<ICustomerGroup, Task<ICustomerGroup>> func)
        {
            await WithUpdateableAsync(client, new CustomerGroupDraft(), DefaultCustomerGroupDraft, func, CreateCustomerGroup,
                DeleteCustomerGroup);
        }

        #endregion
    }
}