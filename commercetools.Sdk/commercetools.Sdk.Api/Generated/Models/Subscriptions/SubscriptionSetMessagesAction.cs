using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Subscriptions
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
