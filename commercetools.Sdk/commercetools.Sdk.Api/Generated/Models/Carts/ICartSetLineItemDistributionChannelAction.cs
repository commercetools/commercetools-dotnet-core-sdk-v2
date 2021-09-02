using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetLineItemDistributionChannelAction))]
    public partial interface ICartSetLineItemDistributionChannelAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }
    }
}
