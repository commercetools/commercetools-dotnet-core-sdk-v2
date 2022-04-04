using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


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

        List<IChangeSubscription> Changes { get; set; }

        IDestination Destination { get; set; }

        string Key { get; set; }

        List<IMessageSubscription> Messages { get; set; }

        IDeliveryFormat Format { get; set; }

        ISubscriptionHealthStatus Status { get; set; }
    }
}
