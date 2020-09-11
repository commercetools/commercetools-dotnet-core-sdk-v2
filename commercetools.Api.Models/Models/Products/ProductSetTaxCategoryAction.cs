using commercetools.Api.Models.Products;
using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class ProductSetTaxCategoryAction : ProductUpdateAction
    {
        public TaxCategoryResourceIdentifier TaxCategory { get; set;}
    }
}
