using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setAssetCustomField")]
    public partial class ProductSetAssetCustomFieldAction : ProductUpdateAction
    {
        public long VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public bool Staged { get; set;}
        
        public string AssetId { get; set;}
        
        public string AssetKey { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public ProductSetAssetCustomFieldAction()
        { 
           this.Action = "setAssetCustomField";
        }
    }
}
