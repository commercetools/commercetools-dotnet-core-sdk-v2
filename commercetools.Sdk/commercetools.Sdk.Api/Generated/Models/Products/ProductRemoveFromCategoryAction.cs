using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class ProductRemoveFromCategoryAction : IProductRemoveFromCategoryAction
    {
        public string Action { get; set; }

        public ICategoryResourceIdentifier Category { get; set; }

        public bool? Staged { get; set; }
        public ProductRemoveFromCategoryAction()
        {
            this.Action = "removeFromCategory";
        }
    }
}
