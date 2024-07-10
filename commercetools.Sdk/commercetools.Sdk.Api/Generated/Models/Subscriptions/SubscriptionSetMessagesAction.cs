using commercetools.Sdk.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class SubscriptionSetMessagesAction : ISubscriptionSetMessagesAction
    {
        public string Action { get; set; }

        public IList<IMessageSubscription> Messages { get; set; }
        public IEnumerable<IMessageSubscription> MessagesEnumerable { set => Messages = value.ToList(); }

        public SubscriptionSetMessagesAction()
        {
            this.Action = "setMessages";
        }
    }
}
