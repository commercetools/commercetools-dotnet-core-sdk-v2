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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelSetCustomFieldAction))]
    public partial interface IChannelSetCustomFieldAction : IChannelUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
