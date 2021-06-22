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
        
        IDiscountedPrice Discounted { get; set;}
    }
}
