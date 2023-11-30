using System.Threading.Tasks;
using commercetools.Api.NewRelicExample.Models;
using commercetools.Api.NewRelicExample.Services;
using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
using Microsoft.AspNetCore.Mvc;

namespace commercetools.Api.NewRelicExample.Controllers
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
                var signInResult = await _meServices.SignIn(model.Email, model.Password);
                if (signInResult.IsValidCredentials)
                {
                    //after signin, the anonymous access token and refresh token are immediately invalid
                    //we need to get new access and refresh tokens with the password flow
                    _userCredentialsStore.StoreUserCredentialsAndClearToken(model.Email, model.Password);
                    return RedirectToAction("Index", "MyCart");
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
            await Task.CompletedTask;
            _userCredentialsStore.ClearCredentialsAndToken();
            return RedirectToAction("Index", "Home");
        }
    }
}