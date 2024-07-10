using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderUpdateSyncInfoAction : IStagedOrderUpdateSyncInfoAction
    {
        public string Action { get; set; }

        public string ExternalId { get; set; }

        public IChannelResourceIdentifier Channel { get; set; }

        public DateTime? SyncedAt { get; set; }
        public StagedOrderUpdateSyncInfoAction()
        {
            this.Action = "updateSyncInfo";
        }
    }
}
