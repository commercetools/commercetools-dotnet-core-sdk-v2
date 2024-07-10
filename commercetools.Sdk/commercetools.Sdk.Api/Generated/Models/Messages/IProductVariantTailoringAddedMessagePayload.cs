using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.ProductTailorings;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductVariantTailoringAddedMessagePayload))]
    public partial interface IProductVariantTailoringAddedMessagePayload : IMessagePayload
    {
        IStoreKeyReference Store { get; set; }

        string ProductKey { get; set; }

        IProductReference Product { get; set; }

        long VariantId { get; set; }

        IProductVariantTailoring Variant { get; set; }

    }
}
