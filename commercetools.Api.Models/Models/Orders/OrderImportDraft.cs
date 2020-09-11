using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

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
        
        public OrderState OrderState { get; set;}
        
        public ShipmentState ShipmentState { get; set;}
        
        public PaymentState PaymentState { get; set;}
        
        public ShippingInfoImportDraft ShippingInfo { get; set;}
        
        public DateTime CompletedAt { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public InventoryMode InventoryMode { get; set;}
        
        public RoundingMode TaxRoundingMode { get; set;}
        
        public List<Address> ItemShippingAddresses { get; set;}
        
        public StoreResourceIdentifier Store { get; set;}
        
        public CartOrigin Origin { get; set;}
    }
}
