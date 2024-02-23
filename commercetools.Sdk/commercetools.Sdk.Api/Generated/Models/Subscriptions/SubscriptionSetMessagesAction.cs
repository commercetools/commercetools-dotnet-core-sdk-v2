using System.Collections.Generic;
using System.Linq;


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
