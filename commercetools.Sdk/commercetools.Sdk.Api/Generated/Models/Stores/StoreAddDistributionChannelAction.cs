using commercetools.Sdk.Api.Models.Channels;


namespace commercetools.Sdk.Api.Models.Stores
{
    public partial class StoreAddDistributionChannelAction : IStoreAddDistributionChannelAction
    {
        public string Action { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }
        public StoreAddDistributionChannelAction()
        {
            this.Action = "addDistributionChannel";
        }
    }
}
