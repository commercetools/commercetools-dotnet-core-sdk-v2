using commercetools.Sdk.Api.Models.Searches;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchFacetRangesValue : IProductSearchFacetRangesValue
    {
        public string Name { get; set; }

        public IProductSearchFacetScopeEnum Scope { get; set; }

        public ISearchQuery Filter { get; set; }

        public IProductSearchFacetCountLevelEnum Level { get; set; }

        public string Field { get; set; }

        public IList<IProductSearchFacetRangesFacetRange> Ranges { get; set; }
        public IEnumerable<IProductSearchFacetRangesFacetRange> RangesEnumerable { set => Ranges = value.ToList(); }


        public string Language { get; set; }

        public ISearchFieldType FieldType { get; set; }
    }
}
