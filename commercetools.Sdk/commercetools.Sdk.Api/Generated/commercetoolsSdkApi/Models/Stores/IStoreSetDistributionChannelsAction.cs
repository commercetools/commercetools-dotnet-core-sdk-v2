using commercetools.Sdk.Api.Models.Channels;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetDistributionChannelsAction))]
    public partial interface IStoreSetDistributionChannelsAction : IStoreUpdateAction
    {
        IList<IChannelResourceIdentifier> DistributionChannels { get; set; }
        IEnumerable<IChannelResourceIdentifier> DistributionChannelsEnumerable { set => DistributionChannels = value.ToList(); }


    }
}
