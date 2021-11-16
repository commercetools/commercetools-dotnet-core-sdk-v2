using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartDraft))]
    public partial interface IMyCartDraft 
    {
        string Currency { get; set;}
        
        string CustomerEmail { get; set;}
        
        string Country { get; set;}
        
        IInventoryMode InventoryMode { get; set;}
        
        List<IMyLineItemDraft> LineItems { get; set;}
        
        IBaseAddress ShippingAddress { get; set;}
        
        IBaseAddress BillingAddress { get; set;}
        
        IShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        string Locale { get; set;}
        
        ITaxMode TaxMode { get; set;}
        
        long? DeleteDaysAfterLastModification { get; set;}
        
        List<IBaseAddress> ItemShippingAddresses { get; set;}
        
        IStoreKeyReference Store { get; set;}
        
        List<IDiscountCodeInfo> DiscountCodes { get; set;}
    }
}
