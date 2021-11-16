using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;


namespace commercetools.Api.Models.Carts
{
    public partial class LineItemDraft : ILineItemDraft
    {
        public string ProductId { get; set;}
        
        public long? VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public long? Quantity { get; set;}
        
        public DateTime? AddedAt { get; set;}
        
        public IChannelResourceIdentifier SupplyChannel { get; set;}
        
        public IChannelResourceIdentifier DistributionChannel { get; set;}
        
        public IExternalTaxRateDraft ExternalTaxRate { get; set;}
        
        public ICustomFieldsDraft Custom { get; set;}
        
        public IMoney ExternalPrice { get; set;}
        
        public IExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
        
        public IItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
