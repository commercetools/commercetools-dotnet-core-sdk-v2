using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("changeAssetOrder")]
    public partial class ProductChangeAssetOrderAction : ProductUpdateAction
    {
        public long VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public bool Staged { get; set;}
        
        public List<string> AssetOrder { get; set;}
        public ProductChangeAssetOrderAction()
        { 
           this.Action = "changeAssetOrder";
        }
    }
}
