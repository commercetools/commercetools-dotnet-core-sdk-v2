using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Api.Models.Channels.ChannelUpdate))]
    public partial interface IChannelUpdate : commercetools.Api.Models.IResourceUpdate<IChannelUpdate, IChannelUpdateAction>
    {
        new long Version { get; set; }
        new List<IChannelUpdateAction> Actions { get; set; }
    }
}
