using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchRequest : IProductSearchRequest
    {
        public IProductSearchQuery Query { get; set; }

        public IProductSearchQuery PostFilter { get; set; }

        public IList<IProductSearchSorting> Sort { get; set; }
        public IEnumerable<IProductSearchSorting> SortEnumerable { set => Sort = value.ToList(); }


        public int? Limit { get; set; }

        public int? Offset { get; set; }

        public bool? MarkMatchingVariants { get; set; }

        public IProductSearchProjectionParams Projection { get; set; }

        public IList<IProductSearchFacetExpression> Facets { get; set; }
        public IEnumerable<IProductSearchFacetExpression> FacetsEnumerable { set => Facets = value.ToList(); }

    }
}
