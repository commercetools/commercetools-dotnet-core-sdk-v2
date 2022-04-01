using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Products
{
    public partial class ProductProjectionPagedQueryResponse : IProductProjectionPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public List<IProductProjection> Results { get; set; }
    }
}
