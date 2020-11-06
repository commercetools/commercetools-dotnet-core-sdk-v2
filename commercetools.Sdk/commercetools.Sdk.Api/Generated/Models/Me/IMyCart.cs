using commercetools.Api.Models.CartDiscounts;
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


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCart))]
    public partial interface IMyCart : IBaseResource
    {
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        string CustomerId { get; set;}
        
        string CustomerEmail { get; set;}
        
        string AnonymousId { get; set;}
        
        IStoreKeyReference Store { get; set;}
        
        List<ILineItem> LineItems { get; set;}
        
        List<ICustomLineItem> CustomLineItems { get; set;}
        
        ITypedMoney TotalPrice { get; set;}
        
        ITaxedPrice TaxedPrice { get; set;}
        
        string CartState { get; set;}
        
        CartState CartStateAsEnum { get; }
        
        IAddress ShippingAddress { get; set;}
        
        IAddress BillingAddress { get; set;}
        
        string InventoryMode { get; set;}
        
        InventoryMode InventoryModeAsEnum { get; }
        
        string TaxMode { get; set;}
        
        TaxMode TaxModeAsEnum { get; }
        
        string TaxRoundingMode { get; set;}
        
        RoundingMode TaxRoundingModeAsEnum { get; }
        
        string TaxCalculationMode { get; set;}
        
        TaxCalculationMode TaxCalculationModeAsEnum { get; }
        
        ICustomerGroupReference CustomerGroup { get; set;}
        
        string Country { get; set;}
        
        IShippingInfo ShippingInfo { get; set;}
        
        List<IDiscountCodeInfo> DiscountCodes { get; set;}
        
        ICustomFields Custom { get; set;}
        
        IPaymentInfo PaymentInfo { get; set;}
        
        string Locale { get; set;}
        
        int? DeleteDaysAfterLastModification { get; set;}
        
        List<ICartDiscountReference> RefusedGifts { get; set;}
        
        string Origin { get; set;}
        
        CartOrigin OriginAsEnum { get; }
        
        IShippingRateInput ShippingRateInput { get; set;}
        
        List<IAddress> ItemShippingAddresses { get; set;}
    }
}
