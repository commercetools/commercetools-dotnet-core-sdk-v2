using commercetools.Sdk.Api.Models.Channels;


namespace commercetools.Sdk.Api.Models.Stores
{
    public partial class StoreRemoveDistributionChannelAction : IStoreRemoveDistributionChannelAction
    {
        public string Action { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }
        public StoreRemoveDistributionChannelAction()
        {
            this.Action = "removeDistributionChannel";
        }
    }
}
