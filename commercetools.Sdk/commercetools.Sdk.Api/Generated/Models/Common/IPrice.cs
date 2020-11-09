using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.Price))]
    public partial interface IPrice 
    {
        string Id { get; set;}
        
        ITypedMoney Value { get; set;}
        
        string Country { get; set;}
        
        ICustomerGroupReference CustomerGroup { get; set;}
        
        IChannelReference Channel { get; set;}
        
        DateTime ValidFrom { get; set;}
        
        DateTime ValidUntil { get; set;}
        
        IDiscountedPrice Discounted { get; set;}
        
        ICustomFields Custom { get; set;}
        
        List<IPriceTier> Tiers { get; set;}
    }
}
