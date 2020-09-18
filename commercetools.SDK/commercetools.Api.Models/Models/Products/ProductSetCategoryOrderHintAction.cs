using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setCategoryOrderHint")]
    public class ProductSetCategoryOrderHintAction : ProductUpdateAction
    {
        public string CategoryId { get; set;}
        
        public string OrderHint { get; set;}
        
        public bool Staged { get; set;}
    }
}
