using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyLineItemDraft : IMyLineItemDraft
    {
        public string ProductId { get; set;}
        
        public long? VariantId { get; set;}
        
        public long Quantity { get; set;}
        
        public DateTime AddedAt { get; set;}
        
        public IChannelResourceIdentifier SupplyChannel { get; set;}
        
        public IChannelResourceIdentifier DistributionChannel { get; set;}
        
        public ICustomFieldsDraft Custom { get; set;}
        
        public IItemShippingDetailsDraft ShippingDetails { get; set;}
        
        public string Sku { get; set;}
    }
}
