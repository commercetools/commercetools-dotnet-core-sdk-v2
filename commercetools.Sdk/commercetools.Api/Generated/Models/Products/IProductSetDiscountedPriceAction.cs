using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IProductSetDiscountedPriceAction : IProductUpdateAction
    {
        string PriceId { get; set;}
        
        bool Staged { get; set;}
        
        IDiscountedPrice Discounted { get; set;}
    }
}
