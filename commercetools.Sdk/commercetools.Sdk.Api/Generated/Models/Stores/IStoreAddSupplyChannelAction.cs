using commercetools.Sdk.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreAddSupplyChannelAction))]
    public partial interface IStoreAddSupplyChannelAction : IStoreUpdateAction
    {
        IChannelResourceIdentifier SupplyChannel { get; set; }
    }
}
