using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderUpdateSyncInfoAction))]
    public interface IOrderUpdateSyncInfoAction : IOrderUpdateAction
    {
        IChannelResourceIdentifier Channel { get; set;}
        
        string ExternalId { get; set;}
        
        DateTime SyncedAt { get; set;}
    }
}
