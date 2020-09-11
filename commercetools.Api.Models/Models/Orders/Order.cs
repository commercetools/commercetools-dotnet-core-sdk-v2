using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.OrderEdits;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.States;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class Order : BaseResource
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
        
        public TaxMode TaxMode { get; set;}
        
        public RoundingMode TaxRoundingMode { get; set;}
        
        public CustomerGroupReference CustomerGroup { get; set;}
        
        public string Country { get; set;}
        
        public OrderState OrderState { get; set;}
        
        public StateReference State { get; set;}
        
        public ShipmentState ShipmentState { get; set;}
        
        public PaymentState PaymentState { get; set;}
        
        public ShippingInfo ShippingInfo { get; set;}
        
        public List<SyncInfo> SyncInfo { get; set;}
        
        public List<ReturnInfo> ReturnInfo { get; set;}
        
        public List<DiscountCodeInfo> DiscountCodes { get; set;}
        
        public long LastMessageSequenceNumber { get; set;}
        
        public CartReference Cart { get; set;}
        
        public CustomFields Custom { get; set;}
        
        public PaymentInfo PaymentInfo { get; set;}
        
        public string Locale { get; set;}
        
        public InventoryMode InventoryMode { get; set;}
        
        public CartOrigin Origin { get; set;}
        
        public TaxCalculationMode TaxCalculationMode { get; set;}
        
        public ShippingRateInput ShippingRateInput { get; set;}
        
        public List<Address> ItemShippingAddresses { get; set;}
        
        public List<CartDiscountReference> RefusedGifts { get; set;}
    }
}
