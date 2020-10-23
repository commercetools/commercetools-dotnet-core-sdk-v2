using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IProductSetPricesAction : IProductUpdateAction
    {
        long VariantId { get; set;}
        
        string Sku { get; set;}
        
        List<IPriceDraft> Prices { get; set;}
        
        bool Staged { get; set;}
    }
}
