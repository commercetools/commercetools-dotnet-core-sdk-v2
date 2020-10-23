using commercetools.Api.Models.Products;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductSetProductPriceCustomTypeAction))]
    public interface IProductSetProductPriceCustomTypeAction : IProductUpdateAction
    {
        string PriceId { get; set;}
        
        bool Staged { get; set;}
        
        ITypeResourceIdentifier Type { get; set;}
        
        IFieldContainer Fields { get; set;}
    }
}
