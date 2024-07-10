using commercetools.Sdk.Api.Models.ProductSearches;
using commercetools.Sdk.Api.Models.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchFacetDistinctValue : IProductSearchFacetDistinctValue
    {
        public string Name { get; set; }

        public IProductSearchFacetScopeEnum Scope { get; set; }

        public ISearchQuery Filter { get; set; }

        public IProductSearchFacetCountLevelEnum Level { get; set; }

        public string Field { get; set; }

        public IList<string> Includes { get; set; }
        public IEnumerable<string> IncludesEnumerable { set => Includes = value.ToList(); }


        public IProductSearchFacetDistinctBucketSortExpression Sort { get; set; }

        public int? Limit { get; set; }

        public string Language { get; set; }

        public ISearchFieldType FieldType { get; set; }

        public string Missing { get; set; }
    }
}
