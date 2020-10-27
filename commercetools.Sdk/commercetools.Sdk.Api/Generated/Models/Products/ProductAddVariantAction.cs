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
    public  partial class ProductAddVariantAction : IProductAddVariantAction
    {
        public string Action { get; set;}
        
        public string Sku { get; set;}
        
        public string Key { get; set;}
        
        public List<IPriceDraft> Prices { get; set;}
        
        public List<IImage> Images { get; set;}
        
        public List<IAttribute> Attributes { get; set;}
        
        public bool? Staged { get; set;}
        
        public List<IAsset> Assets { get; set;}
        public ProductAddVariantAction()
        { 
           this.Action = "addVariant";
        }
    }
}
