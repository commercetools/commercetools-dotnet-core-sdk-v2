using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("giftLineItem")]
    public partial class CartDiscountValueGiftLineItemDraft : CartDiscountValueDraft
    {
        public ProductReference Product { get; set;}
        
        public long VariantId { get; set;}
        
        public ChannelReference SupplyChannel { get; set;}
        
        public ChannelReference DistributionChannel { get; set;}
        public CartDiscountValueGiftLineItemDraft()
        { 
           this.Type = "giftLineItem";
        }
    }
}
