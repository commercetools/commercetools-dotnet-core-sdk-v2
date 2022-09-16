using commercetools.Sdk.Api.Models.Channels;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreSupplyChannelsChangedMessage))]
    public partial interface IStoreSupplyChannelsChangedMessage : IMessage
    {
        List<IChannelReference> AddedSupplyChannels { get; set; }

        List<IChannelReference> RemovedSupplyChannels { get; set; }

    }
}
