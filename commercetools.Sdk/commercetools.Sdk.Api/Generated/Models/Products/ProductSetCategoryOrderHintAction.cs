using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductSetCategoryOrderHintAction : IProductSetCategoryOrderHintAction
    {
        public string Action { get; set; }

        public string CategoryId { get; set; }

        public string OrderHint { get; set; }

        public bool? Staged { get; set; }
        public ProductSetCategoryOrderHintAction()
        {
            this.Action = "setCategoryOrderHint";
        }
    }
}
