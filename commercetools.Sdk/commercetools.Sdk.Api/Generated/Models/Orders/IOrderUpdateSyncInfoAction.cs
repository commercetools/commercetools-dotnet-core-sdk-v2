using commercetools.Api.Models.Channels;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderUpdateSyncInfoAction))]
    public partial interface IOrderUpdateSyncInfoAction : IOrderUpdateAction
    {
        IChannelResourceIdentifier Channel { get; set; }

        string ExternalId { get; set; }

        DateTime? SyncedAt { get; set; }
    }
}
