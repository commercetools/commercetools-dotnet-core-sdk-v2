using System.Threading.Tasks;
using commercetools.Api.DynatraceExample.Models;
using commercetools.Api.DynatraceExample.Services;
using commercetools.Sdk.Api.Models.Me;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
using Microsoft.AspNetCore.Mvc;

namespace commercetools.Api.DynatraceExample.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ProductServices _productServices;
        public HomeController(IClient client,
            IUserCredentialsStoreManager userCredentialsStore,
            MeServices meServices,
            CartServices cartServices, ProductServices productServices)
            : base(client, userCredentialsStore, meServices, cartServices)
        {
            this._productServices = productServices;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productServices.GetAllPublishedProducts();
            var customerProfile = await GetCurrentCustomerProfile();
            var homeModel = new HomeViewModel(products, customerProfile);
            return View(homeModel);
        }

        public async Task<IActionResult> AddToCart(IProductProjection product)
        {
            var cartDraft = GetCartDraft();
            var cart = await _cartServices.CreateCartForCurrentCustomer(cartDraft);
            await _cartServices.AddProductToCurrentActiveCart(cart, product);
            return RedirectToAction("Index");
        }

        private IMyCartDraft GetCartDraft()
        {
            var cartDraft = new MyCartDraft
            {
                Currency = Settings.DefaultCurrency,
            };
            return cartDraft;
        }
    }
}