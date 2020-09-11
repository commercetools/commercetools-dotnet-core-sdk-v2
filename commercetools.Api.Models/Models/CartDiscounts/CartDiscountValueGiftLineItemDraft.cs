using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CartDiscounts
{
    public class CartDiscountValueGiftLineItemDraft : CartDiscountValueDraft
    {
        public ProductReference Product { get; set;}
        
        public long VariantId { get; set;}
        
        public ChannelReference SupplyChannel { get; set;}
        
        public ChannelReference DistributionChannel { get; set;}
    }
}
