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
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        DateTime CompletedAt { get; set;}
        
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
        
        string TaxMode { get; set;}
        
        TaxMode TaxModeAsEnum { get; }
        
        string TaxRoundingMode { get; set;}
        
        RoundingMode TaxRoundingModeAsEnum { get; }
        
        ICustomerGroupReference CustomerGroup { get; set;}
        
        string Country { get; set;}
        
        string OrderState { get; set;}
        
        OrderState OrderStateAsEnum { get; }
        
        IStateReference State { get; set;}
        
        string ShipmentState { get; set;}
        
        ShipmentState ShipmentStateAsEnum { get; }
        
        string PaymentState { get; set;}
        
        PaymentState PaymentStateAsEnum { get; }
        
        IShippingInfo ShippingInfo { get; set;}
        
        List<ISyncInfo> SyncInfo { get; set;}
        
        List<IReturnInfo> ReturnInfo { get; set;}
        
        List<IDiscountCodeInfo> DiscountCodes { get; set;}
        
        long LastMessageSequenceNumber { get; set;}
        
        ICartReference Cart { get; set;}
        
        ICustomFields Custom { get; set;}
        
        IPaymentInfo PaymentInfo { get; set;}
        
        string Locale { get; set;}
        
        string InventoryMode { get; set;}
        
        InventoryMode InventoryModeAsEnum { get; }
        
        string Origin { get; set;}
        
        CartOrigin OriginAsEnum { get; }
        
        string TaxCalculationMode { get; set;}
        
        TaxCalculationMode TaxCalculationModeAsEnum { get; }
        
        IShippingRateInput ShippingRateInput { get; set;}
        
        List<IAddress> ItemShippingAddresses { get; set;}
        
        List<ICartDiscountReference> RefusedGifts { get; set;}
    }
}
