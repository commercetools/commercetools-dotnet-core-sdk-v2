using System.Collections.Generic;
using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Products;

namespace commercetools.Api.CheckoutApp.Models
{
    public class HomeViewModel : CustomerProfileViewModel
    {
        public List<IProduct> Products { get; set; }

        public HomeViewModel()
        {
            Products = new List<IProduct>();
        }
        
        public HomeViewModel(List<IProduct> products, CustomerProfileViewModel customerProfile)
        {
            this.Products = products;
            this.ActiveCart = customerProfile.ActiveCart;
            this.Customer = customerProfile.Customer;
        }
    }
}