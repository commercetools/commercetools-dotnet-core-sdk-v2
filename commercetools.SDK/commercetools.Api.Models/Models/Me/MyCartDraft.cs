using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartDraft 
    {
        public string Currency { get; set;}
        
        public string CustomerEmail { get; set;}
        
        public string Country { get; set;}
        
        public string InventoryMode { get; set;}
        
        [JsonIgnore]
        public InventoryMode InventoryModeAsEnum => this.InventoryMode.GetEnum<InventoryMode>();
        
        public List<MyLineItemDraft> LineItems { get; set;}
        
        public Address ShippingAddress { get; set;}
        
        public Address BillingAddress { get; set;}
        
        public ShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public string Locale { get; set;}
        
        public string TaxMode { get; set;}
        
        [JsonIgnore]
        public TaxMode TaxModeAsEnum => this.TaxMode.GetEnum<TaxMode>();
        
        public long DeleteDaysAfterLastModification { get; set;}
        
        public List<Address> ItemShippingAddresses { get; set;}
    }
}
