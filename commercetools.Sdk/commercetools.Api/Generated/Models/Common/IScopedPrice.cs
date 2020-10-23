using commercetools.Api.Generated.Models.Channels;
using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.CustomerGroups;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Common
{
    public interface IScopedPrice 
    {
        string Id { get; set;}
        
        ITypedMoney Value { get; set;}
        
        ITypedMoney CurrentValue { get; set;}
        
        string Country { get; set;}
        
        ICustomerGroupReference CustomerGroup { get; set;}
        
        IChannelReference Channel { get; set;}
        
        DateTime ValidFrom { get; set;}
        
        DateTime ValidUntil { get; set;}
        
        IDiscountedPrice Discounted { get; set;}
        
        ICustomFields Custom { get; set;}
    }
}
