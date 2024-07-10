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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.CloudEventsPayload))]
    public partial interface ICloudEventsPayload
    {
        string Specversion { get; set; }

        string Id { get; set; }

        string Type { get; set; }

        string Source { get; set; }

        string Subject { get; set; }

        DateTime Time { get; set; }

        string Sequence { get; set; }

        string Sequencetype { get; set; }

        string Dataref { get; set; }

        IDeliveryPayload Data { get; set; }

    }
}
