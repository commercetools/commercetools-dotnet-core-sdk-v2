using commercetools.Api.Generated.Models.Channels;
using commercetools.Api.Generated.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.OrderEdits
{
    public interface IStagedOrderUpdateSyncInfoAction : IStagedOrderUpdateAction
    {
        IChannelResourceIdentifier Channel { get; set;}
        
        string ExternalId { get; set;}
        
        DateTime SyncedAt { get; set;}
    }
}
