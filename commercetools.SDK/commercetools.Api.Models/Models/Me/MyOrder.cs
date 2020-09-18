using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.States;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public class MyOrder : BaseResource
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public LastModifiedBy LastModifiedBy { get; set;}
        
        public CreatedBy CreatedBy { get; set;}
        
        public DateTime CompletedAt { get; set;}
        
        public string OrderNumber { get; set;}
        
        public string CustomerId { get; set;}
        
        public string CustomerEmail { get; set;}
        
        public string AnonymousId { get; set;}
        
        public StoreKeyReference Store { get; set;}
        
        public List<LineItem> LineItems { get; set;}
        
        public List<CustomLineItem> CustomLineItems { get; set;}
        
        public TypedMoney TotalPrice { get; set;}
        
        public TaxedPrice TaxedPrice { get; set;}
        
        public Address ShippingAddress { get; set;}
        
        public Address BillingAddress { get; set;}
        
        public string TaxMode { get; set;}
        
        public TaxMode TaxModeAsEnum => this.TaxMode.GetEnum<TaxMode>();
        
        public string TaxRoundingMode { get; set;}
        
        public RoundingMode TaxRoundingModeAsEnum => this.TaxRoundingMode.GetEnum<RoundingMode>();
        
        public CustomerGroupReference CustomerGroup { get; set;}
        
        public string Country { get; set;}
        
        public string OrderState { get; set;}
        
        public OrderState OrderStateAsEnum => this.OrderState.GetEnum<OrderState>();
        
        public StateReference State { get; set;}
        
        public string ShipmentState { get; set;}
        
        public ShipmentState ShipmentStateAsEnum => this.ShipmentState.GetEnum<ShipmentState>();
        
        public string PaymentState { get; set;}
        
        public PaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<PaymentState>();
        
        public ShippingInfo ShippingInfo { get; set;}
        
        public List<SyncInfo> SyncInfo { get; set;}
        
        public List<ReturnInfo> ReturnInfo { get; set;}
        
        public List<DiscountCodeInfo> DiscountCodes { get; set;}
        
        public long LastMessageSequenceNumber { get; set;}
        
        public CartReference Cart { get; set;}
        
        public CustomFields Custom { get; set;}
        
        public PaymentInfo PaymentInfo { get; set;}
        
        public string Locale { get; set;}
        
        public string InventoryMode { get; set;}
        
        public InventoryMode InventoryModeAsEnum => this.InventoryMode.GetEnum<InventoryMode>();
        
        public string Origin { get; set;}
        
        public CartOrigin OriginAsEnum => this.Origin.GetEnum<CartOrigin>();
        
        public string TaxCalculationMode { get; set;}
        
        public TaxCalculationMode TaxCalculationModeAsEnum => this.TaxCalculationMode.GetEnum<TaxCalculationMode>();
        
        public ShippingRateInput ShippingRateInput { get; set;}
        
        public List<Address> ItemShippingAddresses { get; set;}
        
        public List<CartDiscountReference> RefusedGifts { get; set;}
    }
}
