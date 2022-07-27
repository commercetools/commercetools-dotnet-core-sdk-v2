using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Channels
{

    public partial class ChannelUpdate : IChannelUpdate
    {
        public long Version { get; set; }

        public List<IChannelUpdateAction> Actions { get; set; }
    }
}
