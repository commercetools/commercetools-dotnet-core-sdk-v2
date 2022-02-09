using System.Linq;
using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Products;

namespace commercetools.Api.CheckoutApp.Extensions
{
    public static class ProductExtensions
    {
        public static string GetDisplayName(this IProductProjection product)
        {
            var key = product.Name.Keys.FirstOrDefault();
            return key != null ? product.Name[key] : product.Id;
        }
        public static string GetDisplayName(this ILineItem lineItem)
        {
            var key = lineItem.Name.Keys.FirstOrDefault();
            return key != null ? lineItem.Name[key] : lineItem.Id;
        }
    }
}