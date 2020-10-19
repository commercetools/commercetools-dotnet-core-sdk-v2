using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("addToCategory")]
    public partial class ProductAddToCategoryAction : ProductUpdateAction
    {
        public CategoryResourceIdentifier Category { get; set;}
        
        public string OrderHint { get; set;}
        
        public bool Staged { get; set;}
        public ProductAddToCategoryAction()
        { 
           this.Action = "addToCategory";
        }
    }
}
