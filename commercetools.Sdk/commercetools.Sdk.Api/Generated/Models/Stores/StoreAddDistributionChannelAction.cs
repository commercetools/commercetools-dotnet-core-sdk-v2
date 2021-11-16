using commercetools.Api.Models.Channels;


namespace commercetools.Api.Models.Stores
{
    public partial class StoreAddDistributionChannelAction : IStoreAddDistributionChannelAction
    {
        public string Action { get; set;}
        
        public IChannelResourceIdentifier DistributionChannel { get; set;}
        public StoreAddDistributionChannelAction()
        { 
           this.Action = "addDistributionChannel";
        }
    }
}
