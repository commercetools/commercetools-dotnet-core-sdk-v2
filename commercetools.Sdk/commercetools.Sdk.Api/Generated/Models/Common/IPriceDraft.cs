using commercetools.Api.Models.Channels;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.PriceDraft))]
    public partial interface IPriceDraft 
    {
        IMoney Value { get; set;}
        
        string Country { get; set;}
        
        ICustomerGroupResourceIdentifier CustomerGroup { get; set;}
        
        IChannelResourceIdentifier Channel { get; set;}
        
        DateTime? ValidFrom { get; set;}
        
        DateTime? ValidUntil { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        List<IPriceTierDraft> Tiers { get; set;}
        
        IDiscountedPriceDraft Discounted { get; set;}
    }
}
