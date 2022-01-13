using commercetools.Api.Models.Channels;


namespace commercetools.Api.Models.Stores
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
