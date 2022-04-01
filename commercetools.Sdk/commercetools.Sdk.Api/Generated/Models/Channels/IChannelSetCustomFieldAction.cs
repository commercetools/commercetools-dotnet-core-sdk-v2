using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelSetCustomFieldAction))]
    public partial interface IChannelSetCustomFieldAction : IChannelUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }
    }
}
