using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountPagedQueryResponse : ICartDiscountPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<ICartDiscount> Results { get; set; }

        public IEnumerable<ICartDiscount> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
