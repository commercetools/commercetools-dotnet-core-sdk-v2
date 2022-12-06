using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Channels
{

    public partial class ChannelUpdate : IChannelUpdate
    {
        public long Version { get; set; }

        public IList<IChannelUpdateAction> Actions { get; set; }
        public IEnumerable<IChannelUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
