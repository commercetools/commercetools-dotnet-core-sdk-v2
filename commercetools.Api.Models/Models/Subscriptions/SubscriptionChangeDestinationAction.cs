using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Subscriptions
{
    public class SubscriptionChangeDestinationAction : SubscriptionUpdateAction
    {
        public Destination Destination { get; set;}
    }
}
