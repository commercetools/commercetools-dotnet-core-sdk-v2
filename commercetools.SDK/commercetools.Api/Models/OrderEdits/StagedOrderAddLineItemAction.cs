using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("addLineItem")]
    public partial class StagedOrderAddLineItemAction : StagedOrderUpdateAction
    {
        public CustomFieldsDraft Custom { get; set;}
        
        public ChannelResourceIdentifier DistributionChannel { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
        
        public string ProductId { get; set;}
        
        public long VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public double Quantity { get; set;}
        
        public DateTime AddedAt { get; set;}
        
        public ChannelResourceIdentifier SupplyChannel { get; set;}
        
        public Money ExternalPrice { get; set;}
        
        public ExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
        
        public ItemShippingDetailsDraft ShippingDetails { get; set;}
        public StagedOrderAddLineItemAction()
        { 
           this.Action = "addLineItem";
        }
    }
}
