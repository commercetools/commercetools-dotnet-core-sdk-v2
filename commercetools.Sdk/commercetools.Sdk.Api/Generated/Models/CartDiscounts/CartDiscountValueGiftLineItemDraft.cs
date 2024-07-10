using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountValueGiftLineItemDraft : ICartDiscountValueGiftLineItemDraft
    {
        public string Type { get; set; }

        public IProductResourceIdentifier Product { get; set; }

        public long VariantId { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }
        public CartDiscountValueGiftLineItemDraft()
        {
            this.Type = "giftLineItem";
        }
    }
}
