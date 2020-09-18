using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public class OrderImportDraft 
    {
        public string OrderNumber { get; set;}
        
        public string CustomerId { get; set;}
        
        public string CustomerEmail { get; set;}
        
        public List<LineItemImportDraft> LineItems { get; set;}
        
        public List<CustomLineItemDraft> CustomLineItems { get; set;}
        
        public Money TotalPrice { get; set;}
        
        public TaxedPriceDraft TaxedPrice { get; set;}
        
        public Address ShippingAddress { get; set;}
        
        public Address BillingAddress { get; set;}
        
        public CustomerGroupResourceIdentifier CustomerGroup { get; set;}
        
        public string Country { get; set;}
        
        public string OrderState { get; set;}
        
        public OrderState OrderStateAsEnum => this.OrderState.GetEnum<OrderState>();
        
        public string ShipmentState { get; set;}
        
        public ShipmentState ShipmentStateAsEnum => this.ShipmentState.GetEnum<ShipmentState>();
        
        public string PaymentState { get; set;}
        
        public PaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<PaymentState>();
        
        public ShippingInfoImportDraft ShippingInfo { get; set;}
        
        public DateTime CompletedAt { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public string InventoryMode { get; set;}
        
        public InventoryMode InventoryModeAsEnum => this.InventoryMode.GetEnum<InventoryMode>();
        
        public string TaxRoundingMode { get; set;}
        
        public RoundingMode TaxRoundingModeAsEnum => this.TaxRoundingMode.GetEnum<RoundingMode>();
        
        public List<Address> ItemShippingAddresses { get; set;}
        
        public StoreResourceIdentifier Store { get; set;}
        
        public string Origin { get; set;}
        
        public CartOrigin OriginAsEnum => this.Origin.GetEnum<CartOrigin>();
    }
}
