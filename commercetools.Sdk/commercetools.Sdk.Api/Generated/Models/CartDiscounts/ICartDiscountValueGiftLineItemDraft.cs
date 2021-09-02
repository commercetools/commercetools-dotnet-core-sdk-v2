using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueGiftLineItemDraft))]
    public partial interface ICartDiscountValueGiftLineItemDraft : ICartDiscountValueDraft
    {
        IProductResourceIdentifier Product { get; set; }

        long VariantId { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }
    }
}
