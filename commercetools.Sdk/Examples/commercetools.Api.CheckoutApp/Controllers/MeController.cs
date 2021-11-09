using System.Threading.Tasks;
using commercetools.Api.CheckoutApp.Models;
using commercetools.Api.CheckoutApp.Services;
using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
using Microsoft.AspNetCore.Mvc;

namespace commercetools.Api.CheckoutApp.Controllers
{
    public class MeController : BaseController
    {
        public MeController(IClient client,
            MeServices meServices,
            CartServices cartServices,
            IUserCredentialsStoreManager userCredentialsStoreManager) 
            : base(client, userCredentialsStoreManager, meServices, cartServices)
        {
        }

        public async Task<IActionResult> SignIn()
        {
            var customerProfile = await GetCurrentCustomerProfile();
            return View(new SignInCustomerViewModel(customerProfile));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(SignInCustomerViewModel model)
        {
            if (ModelState.IsValid)
            {
                var signInResult = await _meServices.SingIn(model.Email, model.Password);
                if (signInResult.IsValidCredentials)
                {
                    //after signin, the anonymous access token and refresh token are immediately invalid
                    //we need to get new access and refresh tokens with the password flow
                    _userCredentialsStore.StoreUserCredentialsAndClearToken(model.Email, model.Password); 

                    if (signInResult.Customer.IsEmailVerified)
                    {
                        return RedirectToAction("Index", "MyCart");
                    }
                    model.ResetAfterEmailNotVerified();
                }
                
                else
                {
                    model.ResetAfterLoginFailed();
                }
            }
            return View("SignIn", model);
        }
        
        public async Task<IActionResult> Logout()
        {
            _userCredentialsStore.ClearCredentialsAndToken();
            return RedirectToAction("Index", "Home");
        }
    }
}