using System.Collections.Generic;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{
    public partial class SimilarProductsPagedQueryResult : ISimilarProductsPagedQueryResult
    {
        public long Count { get; set; }

        public long Total { get; set; }

        public long Offset { get; set; }

        public List<ISimilarProductPair> Results { get; set; }

        public ISimilarProductSearchRequestMeta Meta { get; set; }
    }
}
