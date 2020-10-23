using commercetools.Api.Generated.Models.CartDiscounts;
using commercetools.Api.Generated.Models.Channels;
using commercetools.Api.Generated.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.CartDiscounts
{
    public interface ICartDiscountValueGiftLineItemDraft : ICartDiscountValueDraft
    {
        IProductReference Product { get; set;}
        
        long VariantId { get; set;}
        
        IChannelReference SupplyChannel { get; set;}
        
        IChannelReference DistributionChannel { get; set;}
    }
}
