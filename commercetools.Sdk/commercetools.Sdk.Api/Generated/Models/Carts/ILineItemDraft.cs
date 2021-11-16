using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.LineItemDraft))]
    public partial interface ILineItemDraft 
    {
        string ProductId { get; set;}
        
        long? VariantId { get; set;}
        
        string Sku { get; set;}
        
        long? Quantity { get; set;}
        
        DateTime? AddedAt { get; set;}
        
        IChannelResourceIdentifier SupplyChannel { get; set;}
        
        IChannelResourceIdentifier DistributionChannel { get; set;}
        
        IExternalTaxRateDraft ExternalTaxRate { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        IMoney ExternalPrice { get; set;}
        
        IExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
        
        IItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
