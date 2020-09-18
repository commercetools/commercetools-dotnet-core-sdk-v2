using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("setMessages")]
    public class SubscriptionSetMessagesAction : SubscriptionUpdateAction
    {
        public List<MessageSubscription> Messages { get; set;}
    }
}
