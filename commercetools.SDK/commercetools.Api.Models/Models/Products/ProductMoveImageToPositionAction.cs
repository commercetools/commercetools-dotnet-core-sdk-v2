using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("moveImageToPosition")]
    public partial class ProductMoveImageToPositionAction : ProductUpdateAction
    {
        public long VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public string ImageUrl { get; set;}
        
        public long Position { get; set;}
        
        public bool Staged { get; set;}
        public ProductMoveImageToPositionAction()
        { 
           this.Action = "moveImageToPosition";
        }
    }
}
