using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("updateSyncInfo")]
    public partial class StagedOrderUpdateSyncInfoAction : StagedOrderUpdateAction
    {
        public ChannelResourceIdentifier Channel { get; set;}
        
        public string ExternalId { get; set;}
        
        public DateTime SyncedAt { get; set;}
        public StagedOrderUpdateSyncInfoAction()
        { 
           this.Action = "updateSyncInfo";
        }
    }
}
