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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductImageAddedMessagePayload))]
    public partial interface IProductImageAddedMessagePayload : IMessagePayload
    {
        long VariantId { get; set; }

        IImage Image { get; set; }

        bool Staged { get; set; }

    }
}
