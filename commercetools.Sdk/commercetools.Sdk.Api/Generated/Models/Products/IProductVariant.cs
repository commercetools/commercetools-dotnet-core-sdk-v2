using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductVariant))]
    public interface IProductVariant 
    {
        long Id { get; set;}
        
        string Sku { get; set;}
        
        string Key { get; set;}
        
        List<IPrice> Prices { get; set;}
        
        List<IAttribute> Attributes { get; set;}
        
        IPrice Price { get; set;}
        
        List<IImage> Images { get; set;}
        
        List<IAsset> Assets { get; set;}
        
        IProductVariantAvailability Availability { get; set;}
        
        bool? IsMatchingVariant { get; set;}
        
        IScopedPrice ScopedPrice { get; set;}
        
        bool? ScopedPriceDiscounted { get; set;}
    }
}
