using commercetools.Sdk.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreRemoveSupplyChannelAction))]
    public partial interface IStoreRemoveSupplyChannelAction : IStoreUpdateAction
    {
        IChannelResourceIdentifier SupplyChannel { get; set; }

    }
}
