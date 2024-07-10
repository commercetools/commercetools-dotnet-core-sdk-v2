using commercetools.Sdk.Api.Models.Categories;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductRemovedFromCategoryMessagePayload : IProductRemovedFromCategoryMessagePayload
    {
        public string Type { get; set; }

        public ICategoryReference Category { get; set; }

        public bool Staged { get; set; }
        public ProductRemovedFromCategoryMessagePayload()
        {
            this.Type = "ProductRemovedFromCategory";
        }
    }
}
