using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.ResourceUpdatedDeliveryPayload))]
    public partial interface IResourceUpdatedDeliveryPayload : IDeliveryPayload
    {
        long Version { get; set; }

        long OldVersion { get; set; }

        DateTime ModifiedAt { get; set; }

    }
}
