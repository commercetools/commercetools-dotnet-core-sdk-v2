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

        IProductSearchFacetEnumScope Scope { get; set; }

        IProductSearchQuery Filter { get; set; }

        IProductSearchFacetEnumCount Count { get; set; }

        string Field { get; set; }

        IList<string> Includes { get; set; }
        IEnumerable<string> IncludesEnumerable { set => Includes = value.ToList(); }


        IProductSearchFacetDistinctStartsWith StartsWith { get; set; }

        IProductSearchFacetDistinctBucketSortExpression Sort { get; set; }

        int? Size { get; set; }

        string Language { get; set; }

        IProductSearchAttributeType AttributeType { get; set; }

        string Missing { get; set; }

    }
}
