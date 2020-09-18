using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("setChanges")]
    public class SubscriptionSetChangesAction : SubscriptionUpdateAction
    {
        public List<ChangeSubscription> Changes { get; set;}
    }
}
