using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productdrafts
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productdrafts.PriceDraftImport))]
    public partial interface IPriceDraftImport 
    {
        ITypedMoney Value { get; set;}
        
        string Country { get; set;}
        
        ICustomerGroupKeyReference CustomerGroup { get; set;}
        
        IChannelKeyReference Channel { get; set;}
        
        DateTime ValidFrom { get; set;}
        
        DateTime ValidUntil { get; set;}
        
        ICustom Custom { get; set;}
        
        IDiscountedPrice Discounted { get; set;}
        
        List<IPriceTier> Tiers { get; set;}
        
        string Key { get; set;}
    }
}
