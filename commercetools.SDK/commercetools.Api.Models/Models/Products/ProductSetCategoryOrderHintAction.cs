using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setCategoryOrderHint")]
    public partial class ProductSetCategoryOrderHintAction : ProductUpdateAction
    {
        public string CategoryId { get; set;}
        
        public string OrderHint { get; set;}
        
        public bool Staged { get; set;}
        public ProductSetCategoryOrderHintAction()
        { 
           this.Action = "setCategoryOrderHint";
        }
    }
}
