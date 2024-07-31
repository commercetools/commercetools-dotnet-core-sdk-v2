using commercetools.Sdk.Api.Models.Searches;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchRequest : IProductSearchRequest
    {
        public ISearchQuery Query { get; set; }

        public IList<ISearchSorting> Sort { get; set; }

        public IEnumerable<ISearchSorting> SortEnumerable { set => Sort = value.ToList(); }

        public int? Limit { get; set; }

        public int? Offset { get; set; }

        public bool? MarkMatchingVariants { get; set; }

        public IProductSearchProjectionParams ProductProjectionParameters { get; set; }

        public IList<IProductSearchFacetExpression> Facets { get; set; }

        public IEnumerable<IProductSearchFacetExpression> FacetsEnumerable { set => Facets = value.ToList(); }

        public ISearchQuery PostFilter { get; set; }
    }
}
