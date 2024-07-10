using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetCountValueQueryBuilderDsl
    {
        public ProductSearchFacetCountValueQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetCountValueQueryBuilderDsl Of()
        {
            return new ProductSearchFacetCountValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchFacetCountValueQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetCountValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductSearchFacetCountValueQueryBuilderDsl>(p, ProductSearchFacetCountValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetCountValueQueryBuilderDsl, string> Scope()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetCountValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("scope")),
            p => new CombinationQueryPredicate<ProductSearchFacetCountValueQueryBuilderDsl>(p, ProductSearchFacetCountValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSearchFacetCountValueQueryBuilderDsl> Filter(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetCountValueQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("filter"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl.Of())),
                ProductSearchFacetCountValueQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductSearchFacetCountValueQueryBuilderDsl, string> Level()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetCountValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("level")),
            p => new CombinationQueryPredicate<ProductSearchFacetCountValueQueryBuilderDsl>(p, ProductSearchFacetCountValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
