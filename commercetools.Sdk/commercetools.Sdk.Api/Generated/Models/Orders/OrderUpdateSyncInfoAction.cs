using commercetools.Sdk.Api.Models.Channels;
using System;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderUpdateSyncInfoAction : IOrderUpdateSyncInfoAction
    {
        public string Action { get; set; }

        public IChannelResourceIdentifier Channel { get; set; }

        public string ExternalId { get; set; }

        public DateTime? SyncedAt { get; set; }
        public OrderUpdateSyncInfoAction()
        {
            this.Action = "updateSyncInfo";
        }
    }
}
