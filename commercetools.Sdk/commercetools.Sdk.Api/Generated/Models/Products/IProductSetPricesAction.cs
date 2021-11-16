using commercetools.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductSetPricesAction))]
    public partial interface IProductSetPricesAction : IProductUpdateAction
    {
        long? VariantId { get; set;}
        
        string Sku { get; set;}
        
        List<IPriceDraft> Prices { get; set;}
        
        bool? Staged { get; set;}
    }
}
