using commercetools.Sdk.Api.Models.Channels;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreDistributionChannelsChangedMessage))]
    public partial interface IStoreDistributionChannelsChangedMessage : IMessage
    {
        List<IChannelReference> AddedDistributionChannels { get; set; }

        List<IChannelReference> RemovedDistributionChannels { get; set; }

    }
}
