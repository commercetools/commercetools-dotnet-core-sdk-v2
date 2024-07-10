using commercetools.Sdk.Api.Models.ProductTailorings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringRemoveVariantAction))]
    public partial interface IProductTailoringRemoveVariantAction : IProductTailoringUpdateAction
    {
        long? Id { get; set; }

        string Sku { get; set; }

        bool? Staged { get; set; }

    }
}
