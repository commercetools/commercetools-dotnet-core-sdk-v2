using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("removeFromCategory")]
    public class ProductRemoveFromCategoryAction : ProductUpdateAction
    {
        public CategoryResourceIdentifier Category { get; set;}
        
        public bool Staged { get; set;}
    }
}
