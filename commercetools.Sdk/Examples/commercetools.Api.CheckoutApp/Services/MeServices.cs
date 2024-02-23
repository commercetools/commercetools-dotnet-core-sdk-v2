using System;
using System.Threading.Tasks;
using commercetools.Api.CheckoutApp.Models;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Extensions;

namespace commercetools.Api.CheckoutApp.Services
{
    public class MeServices
    {
        private readonly IClient _client;

        public MeServices(IClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Customer SignIn and return the result
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<SignInResult> SignIn(string email, string password)
        {
            ICustomerSignInResult result = null;
            var signInResult = new SignInResult();
            try
            {
                result = await _client
                    .WithApi()
                    .WithProjectKey(Settings.ProjectKey)
                    .Me()
                    .Login()
                    .Post(
                        new MyCustomerSignin
                        {
                            Email = email,
                            Password = password
                        })
                    .ExecuteAsync();
                signInResult.IsValidCredentials = true;
            }
            catch (Exception ex)
            {
                signInResult.IsValidCredentials = false;
                signInResult.ErrorMessage = ex.Message;
            }

            if (result != null)
            {
                signInResult.Cart = result.Cart;
                signInResult.Customer = result.Customer;
            }

            return signInResult;
        }

        public async Task<ICustomer> GetMyProfile()
        {
            ICustomer customer = null;
            try
            {
                customer = await _client
                    .WithApi()
                    .WithProjectKey(Settings.ProjectKey)
                    .Me()
                    .Get()
                    .ExecuteAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return customer;
        }

        /// <summary>
        /// User authenticated Me().Get() return current customer profile
        /// </summary>
        public async Task<bool> IsUserAuthenticated() => await GetMyProfile() != null;
    }
}