using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Orders;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderUpdateSyncInfoAction))]
    public partial interface IStagedOrderUpdateSyncInfoAction : IStagedOrderUpdateAction
    {
        IChannelResourceIdentifier Channel { get; set; }

        string ExternalId { get; set; }

        DateTime? SyncedAt { get; set; }
    }
}
