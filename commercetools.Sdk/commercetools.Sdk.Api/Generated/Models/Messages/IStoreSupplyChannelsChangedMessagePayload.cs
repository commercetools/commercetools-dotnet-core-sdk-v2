using commercetools.Sdk.Api.Models.Channels;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreSupplyChannelsChangedMessagePayload))]
    public partial interface IStoreSupplyChannelsChangedMessagePayload : IMessagePayload
    {
        List<IChannelReference> AddedSupplyChannels { get; set; }

        List<IChannelReference> RemovedSupplyChannels { get; set; }

    }
}
