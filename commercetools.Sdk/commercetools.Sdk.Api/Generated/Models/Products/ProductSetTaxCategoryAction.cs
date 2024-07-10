using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductSetTaxCategoryAction : IProductSetTaxCategoryAction
    {
        public string Action { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }
        public ProductSetTaxCategoryAction()
        {
            this.Action = "setTaxCategory";
        }
    }
}
