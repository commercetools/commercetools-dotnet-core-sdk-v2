using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Products;
using Attribute = commercetools.Api.Generated.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IProductAddVariantAction : IProductUpdateAction
    {
        string Sku { get; set;}
        
        string Key { get; set;}
        
        List<IPriceDraft> Prices { get; set;}
        
        List<IImage> Images { get; set;}
        
        List<IAttribute> Attributes { get; set;}
        
        bool Staged { get; set;}
        
        List<IAsset> Assets { get; set;}
    }
}
