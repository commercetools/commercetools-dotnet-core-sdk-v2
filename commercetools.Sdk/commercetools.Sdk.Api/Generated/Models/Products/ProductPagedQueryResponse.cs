using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductPagedQueryResponse : IProductPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public List<IProduct> Results { get; set; }
    }
}
