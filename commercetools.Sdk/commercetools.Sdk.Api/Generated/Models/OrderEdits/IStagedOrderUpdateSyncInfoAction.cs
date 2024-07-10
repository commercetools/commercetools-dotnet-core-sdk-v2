using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Orders;
using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderUpdateSyncInfoAction))]
    public partial interface IStagedOrderUpdateSyncInfoAction : IStagedOrderUpdateAction
    {
        string ExternalId { get; set; }

        IChannelResourceIdentifier Channel { get; set; }

        DateTime? SyncedAt { get; set; }

    }
}
