using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
