using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetImageLabelAction))]
    public partial interface IProductSetImageLabelAction : IProductUpdateAction
    {
        string Sku { get; set; }

        long? VariantId { get; set; }

        string ImageUrl { get; set; }

        string Label { get; set; }

        bool? Staged { get; set; }

    }
}
