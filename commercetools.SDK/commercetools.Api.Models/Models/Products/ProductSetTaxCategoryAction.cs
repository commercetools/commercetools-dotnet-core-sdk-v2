using commercetools.Api.Models.Products;
using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setTaxCategory")]
    public class ProductSetTaxCategoryAction : ProductUpdateAction
    {
        public TaxCategoryResourceIdentifier TaxCategory { get; set;}
    }
}
