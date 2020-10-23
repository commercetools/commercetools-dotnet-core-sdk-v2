using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Carts
{
    public interface ICartSetLineItemDistributionChannelAction : ICartUpdateAction
    {
        string LineItemId { get; set;}
        
        IChannelResourceIdentifier DistributionChannel { get; set;}
    }
}
