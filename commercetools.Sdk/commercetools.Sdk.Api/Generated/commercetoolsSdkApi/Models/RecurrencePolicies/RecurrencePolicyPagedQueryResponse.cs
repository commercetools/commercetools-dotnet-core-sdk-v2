using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{

    public partial class RecurrencePolicyPagedQueryResponse : IRecurrencePolicyPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IRecurrencePolicy> Results { get; set; }

        public IEnumerable<IRecurrencePolicy> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
