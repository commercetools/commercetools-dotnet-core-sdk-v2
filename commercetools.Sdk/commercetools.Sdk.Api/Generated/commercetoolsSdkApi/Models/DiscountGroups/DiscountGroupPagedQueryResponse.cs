using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.DiscountGroups
{

    public partial class DiscountGroupPagedQueryResponse : IDiscountGroupPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IDiscountGroup> Results { get; set; }

        public IEnumerable<IDiscountGroup> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
