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

    public partial class CartDiscountValueGiftLineItem : ICartDiscountValueGiftLineItem
    {
        public string Type { get; set; }

        public IProductReference Product { get; set; }

        public long VariantId { get; set; }

        public IChannelReference SupplyChannel { get; set; }

        public IChannelReference DistributionChannel { get; set; }
        public CartDiscountValueGiftLineItem()
        {
            this.Type = "giftLineItem";
        }
    }
}
