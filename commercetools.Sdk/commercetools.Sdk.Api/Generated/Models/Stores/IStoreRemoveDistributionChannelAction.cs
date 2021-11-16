using commercetools.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.StoreRemoveDistributionChannelAction))]
    public partial interface IStoreRemoveDistributionChannelAction : IStoreUpdateAction
    {
        IChannelResourceIdentifier DistributionChannel { get; set;}
    }
}
