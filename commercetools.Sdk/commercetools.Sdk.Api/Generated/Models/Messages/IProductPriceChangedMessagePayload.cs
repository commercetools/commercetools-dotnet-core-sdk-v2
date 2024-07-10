using commercetools.Sdk.Api.Models.Common;
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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceChangedMessagePayload))]
    public partial interface IProductPriceChangedMessagePayload : IMessagePayload
    {
        long VariantId { get; set; }

        IPrice OldPrice { get; set; }

        IPrice NewPrice { get; set; }

        bool Staged { get; set; }

        IPrice OldStagedPrice { get; set; }

    }
}
