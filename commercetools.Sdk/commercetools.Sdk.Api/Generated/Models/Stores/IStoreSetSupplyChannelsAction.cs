using commercetools.Sdk.Api.Models.Channels;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetSupplyChannelsAction))]
    public partial interface IStoreSetSupplyChannelsAction : IStoreUpdateAction
    {
        List<IChannelResourceIdentifier> SupplyChannels { get; set; }
    }
}
