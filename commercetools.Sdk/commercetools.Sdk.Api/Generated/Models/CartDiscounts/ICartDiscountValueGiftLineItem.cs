using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueGiftLineItem))]
    public partial interface ICartDiscountValueGiftLineItem : ICartDiscountValue
    {
        IProductReference Product { get; set; }

        long VariantId { get; set; }

        IChannelReference SupplyChannel { get; set; }

        IChannelReference DistributionChannel { get; set; }

    }
}
