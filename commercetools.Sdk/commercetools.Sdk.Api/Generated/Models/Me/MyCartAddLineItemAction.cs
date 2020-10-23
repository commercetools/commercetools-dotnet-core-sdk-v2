using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public  partial class MyCartAddLineItemAction : IMyCartAddLineItemAction
    {
        public string Action { get; set;}
        
        public ICustomFieldsDraft Custom { get; set;}
        
        public IChannelResourceIdentifier DistributionChannel { get; set;}
        
        public IExternalTaxRateDraft ExternalTaxRate { get; set;}
        
        public string ProductId { get; set;}
        
        public long VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public double Quantity { get; set;}
        
        public IChannelResourceIdentifier SupplyChannel { get; set;}
        
        public IMoney ExternalPrice { get; set;}
        
        public IExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
        
        public IItemShippingDetailsDraft ShippingDetails { get; set;}
        
        public DateTime AddedAt { get; set;}
        public MyCartAddLineItemAction()
        { 
           this.Action = "addLineItem";
        }
    }
}
