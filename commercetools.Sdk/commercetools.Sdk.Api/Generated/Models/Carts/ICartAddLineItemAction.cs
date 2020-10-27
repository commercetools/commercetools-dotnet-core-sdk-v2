using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartAddLineItemAction))]
    public interface ICartAddLineItemAction : ICartUpdateAction
    {
        ICustomFieldsDraft Custom { get; set;}
        
        IChannelResourceIdentifier DistributionChannel { get; set;}
        
        IExternalTaxRateDraft ExternalTaxRate { get; set;}
        
        string ProductId { get; set;}
        
        long? VariantId { get; set;}
        
        string Sku { get; set;}
        
        long? Quantity { get; set;}
        
        IChannelResourceIdentifier SupplyChannel { get; set;}
        
        IMoney ExternalPrice { get; set;}
        
        IExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
        
        IItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
