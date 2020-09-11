using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class ProductVariant 
    {
        public long Id { get; set;}
        
        public string Sku { get; set;}
        
        public string Key { get; set;}
        
        public List<Price> Prices { get; set;}
        
        public List<Attribute> Attributes { get; set;}
        
        public Price Price { get; set;}
        
        public List<Image> Images { get; set;}
        
        public List<Asset> Assets { get; set;}
        
        public ProductVariantAvailability Availability { get; set;}
        
        public bool IsMatchingVariant { get; set;}
        
        public ScopedPrice ScopedPrice { get; set;}
        
        public bool ScopedPriceDiscounted { get; set;}
    }
}
