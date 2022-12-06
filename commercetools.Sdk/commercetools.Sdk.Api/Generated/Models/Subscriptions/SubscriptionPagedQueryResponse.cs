using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class SubscriptionPagedQueryResponse : ISubscriptionPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<ISubscription> Results { get; set; }
        public IEnumerable<ISubscription> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
