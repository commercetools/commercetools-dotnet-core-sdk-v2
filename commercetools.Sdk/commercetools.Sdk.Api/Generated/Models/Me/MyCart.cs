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
    public partial class MyCart : IMyCart
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public ILastModifiedBy LastModifiedBy { get; set;}
        
        public ICreatedBy CreatedBy { get; set;}
        
        public string CustomerId { get; set;}
        
        public string CustomerEmail { get; set;}
        
        public string AnonymousId { get; set;}
        
        public IStoreKeyReference Store { get; set;}
        
        public List<ILineItem> LineItems { get; set;}
        
        public List<ICustomLineItem> CustomLineItems { get; set;}
        
        public ITypedMoney TotalPrice { get; set;}
        
        public ITaxedPrice TaxedPrice { get; set;}
        
        public ICartState CartState { get; set;}
        
        public IAddress ShippingAddress { get; set;}
        
        public IAddress BillingAddress { get; set;}
        
        public IInventoryMode InventoryMode { get; set;}
        
        public ITaxMode TaxMode { get; set;}
        
        public IRoundingMode TaxRoundingMode { get; set;}
        
        public ITaxCalculationMode TaxCalculationMode { get; set;}
        
        public ICustomerGroupReference CustomerGroup { get; set;}
        
        public string Country { get; set;}
        
        public IShippingInfo ShippingInfo { get; set;}
        
        public List<IDiscountCodeInfo> DiscountCodes { get; set;}
        
        public ICustomFields Custom { get; set;}
        
        public IPaymentInfo PaymentInfo { get; set;}
        
        public string Locale { get; set;}
        
        public int? DeleteDaysAfterLastModification { get; set;}
        
        public List<ICartDiscountReference> RefusedGifts { get; set;}
        
        public ICartOrigin Origin { get; set;}
        
        public IShippingRateInput ShippingRateInput { get; set;}
        
        public List<IAddress> ItemShippingAddresses { get; set;}
    }
}
