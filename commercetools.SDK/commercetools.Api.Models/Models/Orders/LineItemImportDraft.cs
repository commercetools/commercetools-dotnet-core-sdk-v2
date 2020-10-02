using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.TaxCategorys;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class LineItemImportDraft 
    {
        public string ProductId { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public ProductVariantImportDraft Variant { get; set;}
        
        public PriceDraft Price { get; set;}
        
        public double Quantity { get; set;}
        
        public List<ItemState> State { get; set;}
        
        public ChannelResourceIdentifier SupplyChannel { get; set;}
        
        public ChannelResourceIdentifier DistributionChannel { get; set;}
        
        public TaxRate TaxRate { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public ItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
