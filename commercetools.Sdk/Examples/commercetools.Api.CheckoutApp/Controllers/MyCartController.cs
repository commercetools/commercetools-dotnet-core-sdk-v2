using System.Threading.Tasks;
using commercetools.Api.CheckoutApp.Services;
using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
using Microsoft.AspNetCore.Mvc;

namespace commercetools.Api.CheckoutApp.Controllers
{
    public class MyCartController : BaseController
    {
        public MyCartController(IClient client,
            CartServices cartServices,
            MeServices meServices,
            IUserCredentialsStoreManager userCredentialsStoreManager)
            : base(client, userCredentialsStoreManager, meServices, cartServices)
        {
        }

        public async Task<IActionResult> Index()
        {
            var customerProfile = await GetCurrentCustomerProfile();
            return View(customerProfile);
        }

        public async Task<IActionResult> Delete(string lineItemId)
        {
            var myCart = await _cartServices.DeleteLineItem(lineItemId);
            return RedirectToAction("Index");
        }
    }
}