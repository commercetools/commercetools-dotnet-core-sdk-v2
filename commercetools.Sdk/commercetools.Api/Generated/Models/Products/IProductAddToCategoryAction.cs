using commercetools.Api.Generated.Models.Categories;
using commercetools.Api.Generated.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IProductAddToCategoryAction : IProductUpdateAction
    {
        ICategoryResourceIdentifier Category { get; set;}
        
        string OrderHint { get; set;}
        
        bool Staged { get; set;}
    }
}
