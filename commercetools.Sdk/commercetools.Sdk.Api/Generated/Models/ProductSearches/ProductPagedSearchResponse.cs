using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductPagedSearchResponse : IProductPagedSearchResponse
    {
        public long Total { get; set; }

        public int? Offset { get; set; }

        public int? Limit { get; set; }

        public IProductSearchFacetResult Facets { get; set; }

        public IList<IProductSearchHit> Hits { get; set; }
        public IEnumerable<IProductSearchHit> HitsEnumerable { set => Hits = value.ToList(); }

    }
}
