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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetImageLabelAction))]
    public partial interface IProductTailoringSetImageLabelAction : IProductTailoringUpdateAction
    {
        string Sku { get; set; }

        long? VariantId { get; set; }

        string ImageUrl { get; set; }

        string Label { get; set; }

        bool? Staged { get; set; }

    }
}
