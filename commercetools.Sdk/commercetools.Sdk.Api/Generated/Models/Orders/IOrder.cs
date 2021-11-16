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
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.Order))]
    public partial interface IOrder : IBaseResource
    {
        new string Id { get; set;}
        
        new long Version { get; set;}
        
        new DateTime CreatedAt { get; set;}
        
        new DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        DateTime? CompletedAt { get; set;}
        
        string OrderNumber { get; set;}
        
        string CustomerId { get; set;}
        
        string CustomerEmail { get; set;}
        
        string AnonymousId { get; set;}
        
        IStoreKeyReference Store { get; set;}
        
        List<ILineItem> LineItems { get; set;}
        
        List<ICustomLineItem> CustomLineItems { get; set;}
        
        ITypedMoney TotalPrice { get; set;}
        
        ITaxedPrice TaxedPrice { get; set;}
        
        IAddress ShippingAddress { get; set;}
        
        IAddress BillingAddress { get; set;}
        
        ITaxMode TaxMode { get; set;}
        
        IRoundingMode TaxRoundingMode { get; set;}
        
        ICustomerGroupReference CustomerGroup { get; set;}
        
        string Country { get; set;}
        
        IOrderState OrderState { get; set;}
        
        IStateReference State { get; set;}
        
        IShipmentState ShipmentState { get; set;}
        
        IPaymentState PaymentState { get; set;}
        
        IShippingInfo ShippingInfo { get; set;}
        
        List<ISyncInfo> SyncInfo { get; set;}
        
        List<IReturnInfo> ReturnInfo { get; set;}
        
        List<IDiscountCodeInfo> DiscountCodes { get; set;}
        
        long LastMessageSequenceNumber { get; set;}
        
        ICartReference Cart { get; set;}
        
        ICustomFields Custom { get; set;}
        
        IPaymentInfo PaymentInfo { get; set;}
        
        string Locale { get; set;}
        
        IInventoryMode InventoryMode { get; set;}
        
        ICartOrigin Origin { get; set;}
        
        ITaxCalculationMode TaxCalculationMode { get; set;}
        
        IShippingRateInput ShippingRateInput { get; set;}
        
        List<IAddress> ItemShippingAddresses { get; set;}
        
        List<ICartDiscountReference> RefusedGifts { get; set;}
    }
}
