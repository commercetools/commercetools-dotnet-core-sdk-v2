using commercetools.Sdk.Api.Models.Common;
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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.Subscription))]
    public partial interface ISubscription : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        IList<IChangeSubscription> Changes { get; set; }
        IEnumerable<IChangeSubscription> ChangesEnumerable { set => Changes = value.ToList(); }


        IDestination Destination { get; set; }

        string Key { get; set; }

        IList<IMessageSubscription> Messages { get; set; }
        IEnumerable<IMessageSubscription> MessagesEnumerable { set => Messages = value.ToList(); }


        IDeliveryFormat Format { get; set; }

        ISubscriptionHealthStatus Status { get; set; }

    }
}
