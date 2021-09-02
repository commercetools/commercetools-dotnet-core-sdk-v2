using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    public partial class SubscriptionSetMessagesAction : ISubscriptionSetMessagesAction
    {
        public string Action { get; set; }

        public List<IMessageSubscription> Messages { get; set; }
        public SubscriptionSetMessagesAction()
        {
            this.Action = "setMessages";
        }
    }
}
