using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCodePagedQueryResponse : IDiscountCodePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IDiscountCode> Results { get; set; }
        public IEnumerable<IDiscountCode> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
