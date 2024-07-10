using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemDistributionChannelAction))]
    public partial interface ICartSetLineItemDistributionChannelAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }

    }
}
