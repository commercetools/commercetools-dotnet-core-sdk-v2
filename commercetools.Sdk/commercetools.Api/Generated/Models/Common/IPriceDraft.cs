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
    public interface IPriceDraft 
    {
        IMoney Value { get; set;}
        
        string Country { get; set;}
        
        ICustomerGroupResourceIdentifier CustomerGroup { get; set;}
        
        IChannelResourceIdentifier Channel { get; set;}
        
        DateTime ValidFrom { get; set;}
        
        DateTime ValidUntil { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        List<IPriceTierDraft> Tiers { get; set;}
        
        IDiscountedPrice Discounted { get; set;}
    }
}
