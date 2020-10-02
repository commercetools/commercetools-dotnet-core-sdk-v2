using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("updateSyncInfo")]
    public partial class OrderUpdateSyncInfoAction : OrderUpdateAction
    {
        public ChannelResourceIdentifier Channel { get; set;}
        
        public string ExternalId { get; set;}
        
        public DateTime SyncedAt { get; set;}
        public OrderUpdateSyncInfoAction()
        { 
           this.Action = "updateSyncInfo";
        }
    }
}
