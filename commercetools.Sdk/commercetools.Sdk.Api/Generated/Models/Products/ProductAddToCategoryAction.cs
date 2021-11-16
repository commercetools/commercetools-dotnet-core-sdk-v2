using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class ProductAddToCategoryAction : IProductAddToCategoryAction
    {
        public string Action { get; set;}
        
        public ICategoryResourceIdentifier Category { get; set;}
        
        public string OrderHint { get; set;}
        
        public bool? Staged { get; set;}
        public ProductAddToCategoryAction()
        { 
           this.Action = "addToCategory";
        }
    }
}
