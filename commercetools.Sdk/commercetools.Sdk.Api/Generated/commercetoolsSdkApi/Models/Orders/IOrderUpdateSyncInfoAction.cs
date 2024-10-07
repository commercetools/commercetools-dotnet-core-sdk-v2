using commercetools.Sdk.Api.Models.Channels;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderUpdateSyncInfoAction))]
    public partial interface IOrderUpdateSyncInfoAction : IOrderUpdateAction
    {
        string ExternalId { get; set; }

        IChannelResourceIdentifier Channel { get; set; }

        DateTime? SyncedAt { get; set; }

    }
}
