using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Api.CheckoutApp.Models;
using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Me;
using commercetools.Api.Models.Products;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
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
        public async Task<SignInResult> SingIn(string email, string password)
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
                        new CustomerSignin
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
            var customer = await _client
                .WithApi()
                .WithProjectKey(Settings.ProjectKey)
                .Me()
                .Get()
                .ExecuteAsync();
            return customer;
        }
    }
}