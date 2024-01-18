using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchFacetDistinctValue : IProductSearchFacetDistinctValue
    {
        public string Name { get; set; }

        public IProductSearchFacetEnumScope Scope { get; set; }

        public IProductSearchQuery Filter { get; set; }

        public IProductSearchFacetEnumCount Count { get; set; }

        public string Field { get; set; }

        public IList<string> Includes { get; set; }
        public IEnumerable<string> IncludesEnumerable { set => Includes = value.ToList(); }


        public IProductSearchFacetDistinctStartsWith StartsWith { get; set; }

        public IProductSearchFacetDistinctBucketSortExpression Sort { get; set; }

        public int? Size { get; set; }

        public string Language { get; set; }

        public IProductSearchAttributeType AttributeType { get; set; }

        public string Missing { get; set; }
    }
}
