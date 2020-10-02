using commercetools.Api.Models.Products;
using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setTaxCategory")]
    public partial class ProductSetTaxCategoryAction : ProductUpdateAction
    {
        public TaxCategoryResourceIdentifier TaxCategory { get; set;}
        public ProductSetTaxCategoryAction()
        { 
           this.Action = "setTaxCategory";
        }
    }
}
