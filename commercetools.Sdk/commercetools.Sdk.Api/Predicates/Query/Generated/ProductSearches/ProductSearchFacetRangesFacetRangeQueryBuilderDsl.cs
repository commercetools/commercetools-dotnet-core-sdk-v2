using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetRangesFacetRangeQueryBuilderDsl
    {
        public ProductSearchFacetRangesFacetRangeQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetRangesFacetRangeQueryBuilderDsl Of()
        {
            return new ProductSearchFacetRangesFacetRangeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchFacetRangesFacetRangeQueryBuilderDsl, string> From()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetRangesFacetRangeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("from")),
            p => new CombinationQueryPredicate<ProductSearchFacetRangesFacetRangeQueryBuilderDsl>(p, ProductSearchFacetRangesFacetRangeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetRangesFacetRangeQueryBuilderDsl, string> To()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetRangesFacetRangeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("to")),
            p => new CombinationQueryPredicate<ProductSearchFacetRangesFacetRangeQueryBuilderDsl>(p, ProductSearchFacetRangesFacetRangeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetRangesFacetRangeQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetRangesFacetRangeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductSearchFacetRangesFacetRangeQueryBuilderDsl>(p, ProductSearchFacetRangesFacetRangeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
