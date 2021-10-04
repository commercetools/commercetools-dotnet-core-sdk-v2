using System.Threading.Tasks;
using commercetools.Api.CheckoutApp.Models;
using commercetools.Api.CheckoutApp.Services;
using commercetools.Api.Models.Me;
using commercetools.Api.Models.Products;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace commercetools.Api.CheckoutApp.Controllers
{
    public class MyCartController : BaseController
    {
        private readonly CartServices _cartServices;
        private readonly ProductServices _productServices;
        public MyCartController(IClient client, 
            IConfiguration configuration,
            CartServices cartServices,ProductServices productServices) 
            : base(client, configuration)
        {
            this._cartServices = cartServices;
            this._productServices = productServices;
        }

        public async Task<IActionResult> Index()
        {
            var myCartModel = await _cartServices.GetActiveCartViewModel();
            return View(myCartModel);
        }

        public async Task<IActionResult> Delete(string lineItemId)
        {
            var myCart = await _cartServices.DeleteLineItem(lineItemId);
            return RedirectToAction("Index");
        }
    }
}