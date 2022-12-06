using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{

    public partial class SimilarProductsPagedQueryResult : ISimilarProductsPagedQueryResult
    {
        public long Count { get; set; }

        public long Total { get; set; }

        public long Offset { get; set; }

        public IList<ISimilarProductPair> Results { get; set; }
        public IEnumerable<ISimilarProductPair> ResultsEnumerable { set => Results = value.ToList(); }


        public ISimilarProductSearchRequestMeta Meta { get; set; }
    }
}
