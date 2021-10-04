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
    public class HomeController : BaseController
    {
        private readonly CartServices _cartServices;
        private readonly ProductServices _productServices;
        public HomeController(IClient client, 
            IConfiguration configuration,
            CartServices cartServices,ProductServices productServices) 
            : base(client, configuration)
        {
            this._cartServices = cartServices;
            this._productServices = productServices;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productServices.GetAllProducts();
            var activeCart = await _cartServices.GetActiveCartViewModel();
            var homeModel = new HomeViewModel
            {
                Products = products,
                ActiveCart = activeCart
            };
            return View(homeModel);
        }

        public async Task<IActionResult> AddToCart(Product product)
        {
            var cartDraft = GetCartDraft();
            var cart = await _cartServices.CreateCartForCurrentCustomer(cartDraft);
            var updatedCart=await _cartServices.AddProductToCurrentActiveCart(cart, product);
            return RedirectToAction("Index");
        }

        private IMyCartDraft GetCartDraft()
        {
            var cartDraft = new MyCartDraft
            {
                Currency = "EUR",
            };
            return cartDraft;
        }
    }
}