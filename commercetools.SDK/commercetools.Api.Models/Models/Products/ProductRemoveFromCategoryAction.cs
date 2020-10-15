using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("removeFromCategory")]
    public partial class ProductRemoveFromCategoryAction : ProductUpdateAction
    {
        public CategoryResourceIdentifier Category { get; set;}
        
        public bool Staged { get; set;}
        public ProductRemoveFromCategoryAction()
        { 
           this.Action = "removeFromCategory";
        }
    }
}
