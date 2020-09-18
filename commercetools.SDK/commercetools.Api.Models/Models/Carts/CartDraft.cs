using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public class CartDraft 
    {
        public string Currency { get; set;}
        
        public string CustomerId { get; set;}
        
        public string CustomerEmail { get; set;}
        
        public CustomerGroupResourceIdentifier CustomerGroup { get; set;}
        
        public string AnonymousId { get; set;}
        
        public StoreResourceIdentifier Store { get; set;}
        
        public string Country { get; set;}
        
        public string InventoryMode { get; set;}
        
        public InventoryMode InventoryModeAsEnum => this.InventoryMode.GetEnum<InventoryMode>();
        
        public string TaxMode { get; set;}
        
        public TaxMode TaxModeAsEnum => this.TaxMode.GetEnum<TaxMode>();
        
        public string TaxRoundingMode { get; set;}
        
        public RoundingMode TaxRoundingModeAsEnum => this.TaxRoundingMode.GetEnum<RoundingMode>();
        
        public string TaxCalculationMode { get; set;}
        
        public TaxCalculationMode TaxCalculationModeAsEnum => this.TaxCalculationMode.GetEnum<TaxCalculationMode>();
        
        public List<LineItemDraft> LineItems { get; set;}
        
        public List<CustomLineItemDraft> CustomLineItems { get; set;}
        
        public Address ShippingAddress { get; set;}
        
        public Address BillingAddress { get; set;}
        
        public ShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRateForShippingMethod { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public string Locale { get; set;}
        
        public long DeleteDaysAfterLastModification { get; set;}
        
        public string Origin { get; set;}
        
        public CartOrigin OriginAsEnum => this.Origin.GetEnum<CartOrigin>();
        
        public ShippingRateInputDraft ShippingRateInput { get; set;}
        
        public List<Address> ItemShippingAddresses { get; set;}
    }
}
