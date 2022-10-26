using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class MessageSubscription : IMessageSubscription
    {
        public IMessageSubscriptionResourceTypeId ResourceTypeId { get; set; }

        public List<string> Types { get; set; }
    }
}
