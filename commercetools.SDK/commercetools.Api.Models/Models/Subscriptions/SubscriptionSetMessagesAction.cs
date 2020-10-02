using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("setMessages")]
    public partial class SubscriptionSetMessagesAction : SubscriptionUpdateAction
    {
        public List<MessageSubscription> Messages { get; set;}
        public SubscriptionSetMessagesAction()
        { 
           this.Action = "setMessages";
        }
    }
}
