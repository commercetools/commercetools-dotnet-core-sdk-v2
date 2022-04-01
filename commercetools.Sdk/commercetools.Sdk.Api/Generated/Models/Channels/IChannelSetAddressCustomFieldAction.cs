using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelSetAddressCustomFieldAction))]
    public partial interface IChannelSetAddressCustomFieldAction : IChannelUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }
    }
}
