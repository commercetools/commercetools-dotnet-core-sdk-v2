using commercetools.Api.Generated.Models.Products;
using commercetools.Api.Generated.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IProductSetTaxCategoryAction : IProductUpdateAction
    {
        ITaxCategoryResourceIdentifier TaxCategory { get; set;}
    }
}
