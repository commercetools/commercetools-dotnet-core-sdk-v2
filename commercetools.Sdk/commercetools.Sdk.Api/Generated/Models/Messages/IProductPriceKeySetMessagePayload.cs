using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceKeySetMessagePayload))]
    public partial interface IProductPriceKeySetMessagePayload : IMessagePayload
    {
        long VariantId { get; set; }

        string PriceId { get; set; }

        string OldKey { get; set; }

        string Key { get; set; }

        bool Staged { get; set; }

    }
}
