using System.Collections.Generic;
using commercetools.Sdk.Api.Models.Products;

namespace commercetools.Api.CheckoutApp.Models
{
    public class HomeViewModel : CustomerProfileViewModel
    {
        public List<IProductProjection> Products { get; set; }

        public HomeViewModel()
        {
            Products = new List<IProductProjection>();
        }

        public HomeViewModel(List<IProductProjection> products, CustomerProfileViewModel customerProfile)
        {
            this.Products = products;
            this.ActiveCart = customerProfile?.ActiveCart;
            this.Customer = customerProfile?.Customer;
        }
    }
}