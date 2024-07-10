using commercetools.Sdk.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelUpdate))]
    public partial interface IChannelUpdate
    {
        long Version { get; set; }

        IList<IChannelUpdateAction> Actions { get; set; }
        IEnumerable<IChannelUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
