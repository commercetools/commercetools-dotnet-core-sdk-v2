using System.Collections.Generic;


namespace commercetools.Api.Models.Subscriptions
{
    public partial class MessageSubscription : IMessageSubscription
    {
        public string ResourceTypeId { get; set; }

        public List<string> Types { get; set; }
    }
}
