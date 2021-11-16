using commercetools.Api.Models.Channels;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.StoreSetDistributionChannelsAction))]
    public partial interface IStoreSetDistributionChannelsAction : IStoreUpdateAction
    {
        List<IChannelResourceIdentifier> DistributionChannels { get; set;}
    }
}
