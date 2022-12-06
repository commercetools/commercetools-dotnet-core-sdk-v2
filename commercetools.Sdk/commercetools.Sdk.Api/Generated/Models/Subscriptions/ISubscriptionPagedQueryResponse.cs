using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionPagedQueryResponse))]
    public partial interface ISubscriptionPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<ISubscription> Results { get; set; }
        IEnumerable<ISubscription> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
