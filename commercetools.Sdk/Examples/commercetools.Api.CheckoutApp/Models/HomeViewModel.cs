using System.Collections.Generic;
using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Products;

namespace commercetools.Api.CheckoutApp.Models
{
    public class HomeViewModel
    {
        public List<IProduct> Products { get; set; }
        public MyCartViewModel ActiveCart { get; set; }
    }
}