using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class MessageSubscription : IMessageSubscription
    {
        public IMessageSubscriptionResourceTypeId ResourceTypeId { get; set; }

        public IList<string> Types { get; set; }
        public IEnumerable<string> TypesEnumerable { set => Types = value.ToList(); }

    }
}
