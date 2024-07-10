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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.ConfluentCloudDestination))]
    public partial interface IConfluentCloudDestination : IDestination
    {
        string BootstrapServer { get; set; }

        string ApiKey { get; set; }

        string ApiSecret { get; set; }

        string Acks { get; set; }

        string Topic { get; set; }

        string Key { get; set; }

    }
}
