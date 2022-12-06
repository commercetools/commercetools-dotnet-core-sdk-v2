using commercetools.Sdk.Api.Models.Channels;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetSupplyChannelsAction))]
    public partial interface IStoreSetSupplyChannelsAction : IStoreUpdateAction
    {
        IList<IChannelResourceIdentifier> SupplyChannels { get; set; }
        IEnumerable<IChannelResourceIdentifier> SupplyChannelsEnumerable { set => SupplyChannels = value.ToList(); }


    }
}
