using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.Channels;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Me
{
    public interface IMyLineItemDraft 
    {
        string ProductId { get; set;}
        
        long VariantId { get; set;}
        
        double Quantity { get; set;}
        
        DateTime AddedAt { get; set;}
        
        IChannelResourceIdentifier SupplyChannel { get; set;}
        
        IChannelResourceIdentifier DistributionChannel { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        IItemShippingDetailsDraft ShippingDetails { get; set;}
        
        string Sku { get; set;}
    }
}
