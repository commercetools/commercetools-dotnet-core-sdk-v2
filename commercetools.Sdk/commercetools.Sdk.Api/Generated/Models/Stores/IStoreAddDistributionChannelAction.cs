using commercetools.Sdk.Api.Models.Channels;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreAddDistributionChannelAction))]
    public partial interface IStoreAddDistributionChannelAction : IStoreUpdateAction
    {
        IChannelResourceIdentifier DistributionChannel { get; set; }

    }
}
