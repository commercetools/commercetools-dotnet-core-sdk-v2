using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchFacetBucketResult : IProductSearchFacetBucketResult
    {
        public string Name { get; set; }

        public IList<IProductSearchFacetResultBucket> Buckets { get; set; }
        public IEnumerable<IProductSearchFacetResultBucket> BucketsEnumerable { set => Buckets = value.ToList(); }

    }
}
