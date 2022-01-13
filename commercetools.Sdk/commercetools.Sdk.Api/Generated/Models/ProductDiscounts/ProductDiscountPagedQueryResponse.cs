using System.Collections.Generic;


namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountPagedQueryResponse : IProductDiscountPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public List<IProductDiscount> Results { get; set; }
    }
}
