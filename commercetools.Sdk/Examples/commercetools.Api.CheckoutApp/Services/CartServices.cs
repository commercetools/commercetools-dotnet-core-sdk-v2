using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Api.CheckoutApp.Extensions;
using commercetools.Api.CheckoutApp.Models;
using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Me;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api.Extensions;

namespace commercetools.Api.CheckoutApp.Services
{
    public class CartServices
    {
        private readonly IClient _client;

        public CartServices(IClient client)
        {
            _client = client;
        }

        public async Task<ICart> AddProductToCurrentActiveCart(ICart cart, IProductProjection product, int variantId = 1,
            int quantity = 1)
        {
            var myCartUpdate = new MyCartUpdate
            {
                Version = cart.Version,
                Actions = new List<IMyCartUpdateAction>
                {
                    new MyCartAddLineItemAction
                    {
                        ProductId = product.Id,
                        VariantId = variantId,
                        Quantity = quantity
                    }
                }
            };
            var updatedCart = await _client
                .WithApi()
                .WithProjectKey(Settings.ProjectKey)
                .Me()
                .Carts()
                .WithId(cart.Id)
                .Post(myCartUpdate)
                .ExecuteAsync();
            return updatedCart;
        }

        /// <summary>
        /// Check if the current customer has active cart,then return it, else return new cart
        /// </summary>
        /// <param name="cartDraft"></param>
        /// <returns></returns>
        public async Task<ICart> CreateCartForCurrentCustomer(IMyCartDraft cartDraft)
        {
            ICart cart = await GetActiveCart() ?? await _client
                .WithApi()
                .WithProjectKey(Settings.ProjectKey)
                .Me()
                .Carts()
                .Post(cartDraft)
                .ExecuteAsync();
            return cart;
        }

        public async Task<ICart> GetActiveCart()
        {
            ICart cart = null;
            try
            {
                cart = await _client
                    .WithApi()
                    .WithProjectKey(Settings.ProjectKey)
                    .Me()
                    .ActiveCart()
                    .Get()
                    .ExecuteAsync();
            }
            catch (NotFoundException) { }

            return cart;
        }

        public async Task<MyCartViewModel> GetActiveCartViewModel()
        {
            var myCart = await GetActiveCart();
            var myCartModel = new MyCartViewModel();
            if (myCart != null)
            {
                myCartModel.CartId = myCart.Id;
                foreach (var lineItem in myCart.LineItems)
                {
                    myCartModel.LineItems.Add(new LineItemViewModel
                    {
                        ProductId = lineItem.Id,
                        ProductName = lineItem.GetDisplayName(),
                        LineItemId = lineItem.Id,
                        Quantity = lineItem.Quantity
                    });
                }
            }

            return myCartModel;
        }

        public async Task<ICart> DeleteLineItem(string lineItemId, int quantity = 1)
        {
            var myCart = await GetActiveCart();
            var update = new MyCartUpdate
            {
                Version = myCart.Version,
                Actions = new List<IMyCartUpdateAction>()
                {
                    new MyCartRemoveLineItemAction
                    {
                        LineItemId = lineItemId
                    }
                }
            };
            return await _client.WithApi()
                .WithProjectKey(Settings.ProjectKey)
                .Me()
                .Carts()
                .WithId(myCart.Id)
                .Post(update)
                .ExecuteAsync();
        }
    }
}