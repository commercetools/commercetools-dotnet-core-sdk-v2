using commercetools.Api.Models.Products;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public  partial class ProductSetAssetCustomTypeAction : IProductSetAssetCustomTypeAction
    {
        public string Action { get; set;}
        
        public long? VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public bool? Staged { get; set;}
        
        public string AssetId { get; set;}
        
        public string AssetKey { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public Object Fields { get; set;}
        public ProductSetAssetCustomTypeAction()
        { 
           this.Action = "setAssetCustomType";
        }
    }
}
