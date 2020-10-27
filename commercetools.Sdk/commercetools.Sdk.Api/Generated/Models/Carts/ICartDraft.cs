using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartDraft))]
    public interface ICartDraft 
    {
        string Currency { get; set;}
        
        string CustomerId { get; set;}
        
        string CustomerEmail { get; set;}
        
        ICustomerGroupResourceIdentifier CustomerGroup { get; set;}
        
        string AnonymousId { get; set;}
        
        IStoreResourceIdentifier Store { get; set;}
        
        string Country { get; set;}
        
        string InventoryMode { get; set;}
        
        InventoryMode InventoryModeAsEnum { get; }
        
        string TaxMode { get; set;}
        
        TaxMode TaxModeAsEnum { get; }
        
        string TaxRoundingMode { get; set;}
        
        RoundingMode TaxRoundingModeAsEnum { get; }
        
        string TaxCalculationMode { get; set;}
        
        TaxCalculationMode TaxCalculationModeAsEnum { get; }
        
        List<ILineItemDraft> LineItems { get; set;}
        
        List<ICustomLineItemDraft> CustomLineItems { get; set;}
        
        IAddress ShippingAddress { get; set;}
        
        IAddress BillingAddress { get; set;}
        
        IShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        IExternalTaxRateDraft ExternalTaxRateForShippingMethod { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        string Locale { get; set;}
        
        long? DeleteDaysAfterLastModification { get; set;}
        
        string Origin { get; set;}
        
        CartOrigin OriginAsEnum { get; }
        
        IShippingRateInputDraft ShippingRateInput { get; set;}
        
        List<IAddress> ItemShippingAddresses { get; set;}
        
        List<string> DiscountCodes { get; set;}
    }
}
