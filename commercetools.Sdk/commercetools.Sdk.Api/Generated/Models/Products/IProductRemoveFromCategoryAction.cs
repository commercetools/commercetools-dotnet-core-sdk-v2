using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductRemoveFromCategoryAction))]
    public interface IProductRemoveFromCategoryAction : IProductUpdateAction
    {
        ICategoryResourceIdentifier Category { get; set;}
        
        bool? Staged { get; set;}
    }
}
