using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetTaxCategoryAction))]
    public partial interface IProductSetTaxCategoryAction : IProductUpdateAction
    {
        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

    }
}
