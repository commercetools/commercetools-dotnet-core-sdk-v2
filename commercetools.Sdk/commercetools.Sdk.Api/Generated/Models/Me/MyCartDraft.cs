using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartDraft : IMyCartDraft
    {
        public string Currency { get; set;}
        
        public string CustomerEmail { get; set;}
        
        public string Country { get; set;}
        
        public string InventoryMode { get; set;}
        
        [JsonIgnore]
        public InventoryMode InventoryModeAsEnum => this.InventoryMode.GetEnum<InventoryMode>();
        
        public List<IMyLineItemDraft> LineItems { get; set;}
        
        public IAddress ShippingAddress { get; set;}
        
        public IAddress BillingAddress { get; set;}
        
        public IShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        public ICustomFieldsDraft Custom { get; set;}
        
        public string Locale { get; set;}
        
        public string TaxMode { get; set;}
        
        [JsonIgnore]
        public TaxMode TaxModeAsEnum => this.TaxMode.GetEnum<TaxMode>();
        
        public long? DeleteDaysAfterLastModification { get; set;}
        
        public List<IAddress> ItemShippingAddresses { get; set;}
    }
}
