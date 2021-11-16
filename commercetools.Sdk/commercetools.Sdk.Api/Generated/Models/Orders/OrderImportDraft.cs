using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderImportDraft : IOrderImportDraft
    {
        public string OrderNumber { get; set;}
        
        public string CustomerId { get; set;}
        
        public string CustomerEmail { get; set;}
        
        public List<ILineItemImportDraft> LineItems { get; set;}
        
        public List<ICustomLineItemImportDraft> CustomLineItems { get; set;}
        
        public IMoney TotalPrice { get; set;}
        
        public ITaxedPriceDraft TaxedPrice { get; set;}
        
        public IBaseAddress ShippingAddress { get; set;}
        
        public IBaseAddress BillingAddress { get; set;}
        
        public ICustomerGroupResourceIdentifier CustomerGroup { get; set;}
        
        public string Country { get; set;}
        
        public IOrderState OrderState { get; set;}
        
        public IShipmentState ShipmentState { get; set;}
        
        public IPaymentState PaymentState { get; set;}
        
        public IShippingInfoImportDraft ShippingInfo { get; set;}
        
        public DateTime? CompletedAt { get; set;}
        
        public ICustomFieldsDraft Custom { get; set;}
        
        public IInventoryMode InventoryMode { get; set;}
        
        public IRoundingMode TaxRoundingMode { get; set;}
        
        public List<IBaseAddress> ItemShippingAddresses { get; set;}
        
        public IStoreResourceIdentifier Store { get; set;}
        
        public ICartOrigin Origin { get; set;}
    }
}
