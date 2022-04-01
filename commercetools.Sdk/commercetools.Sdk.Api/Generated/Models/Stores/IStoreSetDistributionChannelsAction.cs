using commercetools.Sdk.Api.Models.Channels;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetDistributionChannelsAction))]
    public partial interface IStoreSetDistributionChannelsAction : IStoreUpdateAction
    {
        List<IChannelResourceIdentifier> DistributionChannels { get; set; }
    }
}
