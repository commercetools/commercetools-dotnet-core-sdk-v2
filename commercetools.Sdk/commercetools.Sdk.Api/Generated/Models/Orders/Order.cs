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
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public  partial class Order : IOrder
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public ILastModifiedBy LastModifiedBy { get; set;}
        
        public ICreatedBy CreatedBy { get; set;}
        
        public DateTime CompletedAt { get; set;}
        
        public string OrderNumber { get; set;}
        
        public string CustomerId { get; set;}
        
        public string CustomerEmail { get; set;}
        
        public string AnonymousId { get; set;}
        
        public IStoreKeyReference Store { get; set;}
        
        public List<ILineItem> LineItems { get; set;}
        
        public List<ICustomLineItem> CustomLineItems { get; set;}
        
        public ITypedMoney TotalPrice { get; set;}
        
        public ITaxedPrice TaxedPrice { get; set;}
        
        public IAddress ShippingAddress { get; set;}
        
        public IAddress BillingAddress { get; set;}
        
        public string TaxMode { get; set;}
        
        [JsonIgnore]
        public TaxMode TaxModeAsEnum => this.TaxMode.GetEnum<TaxMode>();
        
        public string TaxRoundingMode { get; set;}
        
        [JsonIgnore]
        public RoundingMode TaxRoundingModeAsEnum => this.TaxRoundingMode.GetEnum<RoundingMode>();
        
        public ICustomerGroupReference CustomerGroup { get; set;}
        
        public string Country { get; set;}
        
        public string OrderState { get; set;}
        
        [JsonIgnore]
        public OrderState OrderStateAsEnum => this.OrderState.GetEnum<OrderState>();
        
        public IStateReference State { get; set;}
        
        public string ShipmentState { get; set;}
        
        [JsonIgnore]
        public ShipmentState ShipmentStateAsEnum => this.ShipmentState.GetEnum<ShipmentState>();
        
        public string PaymentState { get; set;}
        
        [JsonIgnore]
        public PaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<PaymentState>();
        
        public IShippingInfo ShippingInfo { get; set;}
        
        public List<ISyncInfo> SyncInfo { get; set;}
        
        public List<IReturnInfo> ReturnInfo { get; set;}
        
        public List<IDiscountCodeInfo> DiscountCodes { get; set;}
        
        public long LastMessageSequenceNumber { get; set;}
        
        public ICartReference Cart { get; set;}
        
        public ICustomFields Custom { get; set;}
        
        public IPaymentInfo PaymentInfo { get; set;}
        
        public string Locale { get; set;}
        
        public string InventoryMode { get; set;}
        
        [JsonIgnore]
        public InventoryMode InventoryModeAsEnum => this.InventoryMode.GetEnum<InventoryMode>();
        
        public string Origin { get; set;}
        
        [JsonIgnore]
        public CartOrigin OriginAsEnum => this.Origin.GetEnum<CartOrigin>();
        
        public string TaxCalculationMode { get; set;}
        
        [JsonIgnore]
        public TaxCalculationMode TaxCalculationModeAsEnum => this.TaxCalculationMode.GetEnum<TaxCalculationMode>();
        
        public IShippingRateInput ShippingRateInput { get; set;}
        
        public List<IAddress> ItemShippingAddresses { get; set;}
        
        public List<ICartDiscountReference> RefusedGifts { get; set;}
    }
}
