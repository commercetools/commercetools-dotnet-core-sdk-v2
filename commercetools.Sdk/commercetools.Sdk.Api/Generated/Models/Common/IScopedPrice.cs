using commercetools.Api.Models.Channels;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.ScopedPrice))]
    public partial interface IScopedPrice 
    {
        string Id { get; set;}
        
        ITypedMoney Value { get; set;}
        
        ITypedMoney CurrentValue { get; set;}
        
        string Country { get; set;}
        
        ICustomerGroupReference CustomerGroup { get; set;}
        
        IChannelReference Channel { get; set;}
        
        DateTime? ValidFrom { get; set;}
        
        DateTime? ValidUntil { get; set;}
        
        IDiscountedPrice Discounted { get; set;}
        
        ICustomFields Custom { get; set;}
    }
}
