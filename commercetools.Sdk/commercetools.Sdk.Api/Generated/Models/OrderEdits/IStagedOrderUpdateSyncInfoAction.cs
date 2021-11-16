using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Orders;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderUpdateSyncInfoAction))]
    public partial interface IStagedOrderUpdateSyncInfoAction : IStagedOrderUpdateAction
    {
        IChannelResourceIdentifier Channel { get; set;}
        
        string ExternalId { get; set;}
        
        DateTime? SyncedAt { get; set;}
    }
}
