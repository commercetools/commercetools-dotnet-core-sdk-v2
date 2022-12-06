using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{

    public partial class ProductDiscountPagedQueryResponse : IProductDiscountPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IProductDiscount> Results { get; set; }
        public IEnumerable<IProductDiscount> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
