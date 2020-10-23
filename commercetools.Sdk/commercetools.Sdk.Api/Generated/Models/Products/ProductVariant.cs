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
    public  partial class ProductVariant : IProductVariant
    {
        public long Id { get; set;}
        
        public string Sku { get; set;}
        
        public string Key { get; set;}
        
        public List<IPrice> Prices { get; set;}
        
        public List<IAttribute> Attributes { get; set;}
        
        public IPrice Price { get; set;}
        
        public List<IImage> Images { get; set;}
        
        public List<IAsset> Assets { get; set;}
        
        public IProductVariantAvailability Availability { get; set;}
        
        public bool IsMatchingVariant { get; set;}
        
        public IScopedPrice ScopedPrice { get; set;}
        
        public bool ScopedPriceDiscounted { get; set;}
    }
}
