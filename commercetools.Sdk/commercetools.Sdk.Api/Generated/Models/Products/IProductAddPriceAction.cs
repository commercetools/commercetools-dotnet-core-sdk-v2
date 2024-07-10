using commercetools.Sdk.Api.Models.Common;
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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductAddPriceAction))]
    public partial interface IProductAddPriceAction : IProductUpdateAction
    {
        long? VariantId { get; set; }

        string Sku { get; set; }

        IPriceDraft Price { get; set; }

        bool? Staged { get; set; }

    }
}
