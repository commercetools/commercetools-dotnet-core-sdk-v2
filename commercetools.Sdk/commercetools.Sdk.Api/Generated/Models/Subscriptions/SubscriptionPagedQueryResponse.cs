using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class SubscriptionPagedQueryResponse : ISubscriptionPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public List<ISubscription> Results { get; set; }
    }
}
