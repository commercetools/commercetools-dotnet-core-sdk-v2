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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.MessageDeliveryPayload))]
    public partial interface IMessageDeliveryPayload : IDeliveryPayload
    {
        string Id { get; set; }

        long Version { get; set; }

        DateTime CreatedAt { get; set; }

        DateTime LastModifiedAt { get; set; }

        long SequenceNumber { get; set; }

        long ResourceVersion { get; set; }

        IPayloadNotIncluded PayloadNotIncluded { get; set; }

    }
}
