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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetPriceKeyAction))]
    public partial interface IProductSetPriceKeyAction : IProductUpdateAction
    {
        string PriceId { get; set; }

        bool? Staged { get; set; }

        string Key { get; set; }

    }
}
