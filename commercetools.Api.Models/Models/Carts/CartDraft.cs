using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

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
        
        public InventoryMode InventoryMode { get; set;}
        
        public TaxMode TaxMode { get; set;}
        
        public RoundingMode TaxRoundingMode { get; set;}
        
        public TaxCalculationMode TaxCalculationMode { get; set;}
        
        public List<LineItemDraft> LineItems { get; set;}
        
        public List<CustomLineItemDraft> CustomLineItems { get; set;}
        
        public Address ShippingAddress { get; set;}
        
        public Address BillingAddress { get; set;}
        
        public ShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRateForShippingMethod { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public string Locale { get; set;}
        
        public long DeleteDaysAfterLastModification { get; set;}
        
        public CartOrigin Origin { get; set;}
        
        public ShippingRateInputDraft ShippingRateInput { get; set;}
        
        public List<Address> ItemShippingAddresses { get; set;}
    }
}
