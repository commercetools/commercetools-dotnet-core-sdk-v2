using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("addAsset")]
    public partial class ProductAddAssetAction : ProductUpdateAction
    {
        public long VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public bool Staged { get; set;}
        
        public AssetDraft Asset { get; set;}
        
        public int Position { get; set;}
        public ProductAddAssetAction()
        { 
           this.Action = "addAsset";
        }
    }
}
