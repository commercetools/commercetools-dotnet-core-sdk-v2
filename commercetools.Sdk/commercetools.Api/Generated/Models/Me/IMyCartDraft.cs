using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Me;
using commercetools.Api.Generated.Models.ShippingMethods;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Me
{
    public interface IMyCartDraft 
    {
        string Currency { get; set;}
        
        string CustomerEmail { get; set;}
        
        string Country { get; set;}
        
        string InventoryMode { get; set;}
        
        InventoryMode InventoryModeAsEnum { get; }
        
        List<IMyLineItemDraft> LineItems { get; set;}
        
        IAddress ShippingAddress { get; set;}
        
        IAddress BillingAddress { get; set;}
        
        IShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        string Locale { get; set;}
        
        string TaxMode { get; set;}
        
        TaxMode TaxModeAsEnum { get; }
        
        long DeleteDaysAfterLastModification { get; set;}
        
        List<IAddress> ItemShippingAddresses { get; set;}
    }
}
