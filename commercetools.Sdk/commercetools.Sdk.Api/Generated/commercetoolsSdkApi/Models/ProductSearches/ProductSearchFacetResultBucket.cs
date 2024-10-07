using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchFacetResultBucket : IProductSearchFacetResultBucket
    {
        public string Name { get; set; }

        public IList<IProductSearchFacetResultBucketEntry> Buckets { get; set; }

        public IEnumerable<IProductSearchFacetResultBucketEntry> BucketsEnumerable { set => Buckets = value.ToList(); }
    }
}
