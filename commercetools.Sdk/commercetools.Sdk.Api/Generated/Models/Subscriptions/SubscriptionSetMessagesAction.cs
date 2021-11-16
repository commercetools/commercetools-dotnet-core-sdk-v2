using System.Collections.Generic;


namespace commercetools.Api.Models.Subscriptions
{
    public partial class SubscriptionSetMessagesAction : ISubscriptionSetMessagesAction
    {
        public string Action { get; set;}
        
        public List<IMessageSubscription> Messages { get; set;}
        public SubscriptionSetMessagesAction()
        { 
           this.Action = "setMessages";
        }
    }
}
