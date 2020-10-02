using commercetools.Api.Models.Products;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setAssetCustomType")]
    public partial class ProductSetAssetCustomTypeAction : ProductUpdateAction
    {
        public long VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public bool Staged { get; set;}
        
        public string AssetId { get; set;}
        
        public string AssetKey { get; set;}
        
        public TypeResourceIdentifier Type { get; set;}
        
        public Object Fields { get; set;}
        public ProductSetAssetCustomTypeAction()
        { 
           this.Action = "setAssetCustomType";
        }
    }
}
