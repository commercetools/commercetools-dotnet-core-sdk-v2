using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchFacetRangesValue : IProductSearchFacetRangesValue
    {
        public string Name { get; set; }

        public IProductSearchFacetEnumScope Scope { get; set; }

        public IProductSearchQuery Filter { get; set; }

        public IProductSearchFacetEnumCount Count { get; set; }

        public string Field { get; set; }

        public IList<IProductSearchFacetRangesFacetRange> Ranges { get; set; }
        public IEnumerable<IProductSearchFacetRangesFacetRange> RangesEnumerable { set => Ranges = value.ToList(); }


        public string Language { get; set; }

        public IProductSearchAttributeType AttributeType { get; set; }
    }
}
