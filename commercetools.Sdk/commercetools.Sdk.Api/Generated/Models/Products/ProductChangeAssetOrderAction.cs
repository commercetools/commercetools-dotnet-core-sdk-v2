using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class ProductChangeAssetOrderAction : IProductChangeAssetOrderAction
    {
        public string Action { get; set;}
        
        public long? VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public bool? Staged { get; set;}
        
        public List<string> AssetOrder { get; set;}
        public ProductChangeAssetOrderAction()
        { 
           this.Action = "changeAssetOrder";
        }
    }
}
