using commercetools.Sdk.Api.Models.Channels;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreSupplyChannelsChangedMessage))]
    public partial interface IStoreSupplyChannelsChangedMessage : IMessage
    {
        IList<IChannelReference> AddedSupplyChannels { get; set; }
        IEnumerable<IChannelReference> AddedSupplyChannelsEnumerable { set => AddedSupplyChannels = value.ToList(); }


        IList<IChannelReference> RemovedSupplyChannels { get; set; }
        IEnumerable<IChannelReference> RemovedSupplyChannelsEnumerable { set => RemovedSupplyChannels = value.ToList(); }


    }
}
