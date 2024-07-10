using commercetools.Sdk.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.SyncInfo))]
    public partial interface ISyncInfo
    {
        IChannelReference Channel { get; set; }

        string ExternalId { get; set; }

        DateTime SyncedAt { get; set; }

    }
}
