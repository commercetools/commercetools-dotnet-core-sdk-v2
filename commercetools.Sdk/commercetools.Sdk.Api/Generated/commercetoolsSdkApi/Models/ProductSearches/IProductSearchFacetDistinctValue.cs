using commercetools.Sdk.Api.Models.Searches;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetDistinctValue))]
    public partial interface IProductSearchFacetDistinctValue
    {
        string Name { get; set; }

        IProductSearchFacetScopeEnum Scope { get; set; }

        ISearchQuery Filter { get; set; }

        IProductSearchFacetCountLevelEnum Level { get; set; }

        string Field { get; set; }

        IList<string> Includes { get; set; }

        IEnumerable<string> IncludesEnumerable { set => Includes = value.ToList(); }

        IProductSearchFacetDistinctBucketSortExpression Sort { get; set; }

        int? Limit { get; set; }

        string Language { get; set; }

        ISearchFieldType FieldType { get; set; }

        string Missing { get; set; }

    }
}
