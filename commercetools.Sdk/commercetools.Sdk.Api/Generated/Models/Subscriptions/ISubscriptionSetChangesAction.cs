using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.SubscriptionSetChangesAction))]
    public interface ISubscriptionSetChangesAction : ISubscriptionUpdateAction
    {
        List<IChangeSubscription> Changes { get; set;}
    }
}
