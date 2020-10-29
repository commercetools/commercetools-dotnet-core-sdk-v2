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
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartDraft))]
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
        
        long? DeleteDaysAfterLastModification { get; set;}
        
        List<IAddress> ItemShippingAddresses { get; set;}
    }
}
