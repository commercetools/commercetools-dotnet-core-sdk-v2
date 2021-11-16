using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Api.Models.Channels.ChannelUpdate))]
    public partial interface IChannelUpdate
    {
        long Version { get; set; }

        List<IChannelUpdateAction> Actions { get; set; }
    }
}
