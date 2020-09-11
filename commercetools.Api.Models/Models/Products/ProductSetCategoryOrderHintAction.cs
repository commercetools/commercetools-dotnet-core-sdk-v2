using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class ProductSetCategoryOrderHintAction : ProductUpdateAction
    {
        public string CategoryId { get; set;}
        
        public string OrderHint { get; set;}
        
        public bool Staged { get; set;}
    }
}
