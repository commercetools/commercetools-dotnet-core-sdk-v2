using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelUpdate))]
    public partial interface IChannelUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IChannelUpdate, IChannelUpdateAction>
    {
        new long Version { get; set; }
        new List<IChannelUpdateAction> Actions { get; set; }
    }
}
