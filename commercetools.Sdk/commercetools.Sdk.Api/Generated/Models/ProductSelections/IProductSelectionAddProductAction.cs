using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionAddProductAction))]
    public partial interface IProductSelectionAddProductAction : IProductSelectionUpdateAction
    {
        IProductResourceIdentifier Product { get; set; }

        IProductVariantSelection VariantSelection { get; set; }

    }
}
