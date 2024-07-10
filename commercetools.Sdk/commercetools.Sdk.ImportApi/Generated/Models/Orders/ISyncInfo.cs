using commercetools.Sdk.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.SyncInfo))]
    public partial interface ISyncInfo
    {
        IChannelKeyReference Channel { get; set; }

        string ExternalId { get; set; }

        DateTime SyncedAt { get; set; }

    }
}
