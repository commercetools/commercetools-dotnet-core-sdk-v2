using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchRequestQueryBuilderDsl
    {
        public ProductSearchRequestQueryBuilderDsl()
        {
        }

        public static ProductSearchRequestQueryBuilderDsl Of()
        {
            return new ProductSearchRequestQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchRequestQueryBuilderDsl> Query(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchRequestQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("query"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl.Of())),
                ProductSearchRequestQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSearchRequestQueryBuilderDsl> Sort(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchSortingQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchSortingQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchRequestQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("sort"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchSortingQueryBuilderDsl.Of())),
                ProductSearchRequestQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductSearchRequestQueryBuilderDsl> Sort()
        {
            return new CollectionPredicateBuilder<ProductSearchRequestQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sort")),
                    p => new CombinationQueryPredicate<ProductSearchRequestQueryBuilderDsl>(p, ProductSearchRequestQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ProductSearchRequestQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<ProductSearchRequestQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<ProductSearchRequestQueryBuilderDsl>(p, ProductSearchRequestQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchRequestQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<ProductSearchRequestQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<ProductSearchRequestQueryBuilderDsl>(p, ProductSearchRequestQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchRequestQueryBuilderDsl, bool> MarkMatchingVariants()
        {
            return new ComparisonPredicateBuilder<ProductSearchRequestQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("markMatchingVariants")),
            p => new CombinationQueryPredicate<ProductSearchRequestQueryBuilderDsl>(p, ProductSearchRequestQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSearchRequestQueryBuilderDsl> ProductProjectionParameters(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchProjectionParamsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchProjectionParamsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchRequestQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productProjectionParameters"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchProjectionParamsQueryBuilderDsl.Of())),
                ProductSearchRequestQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSearchRequestQueryBuilderDsl> Facets(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchRequestQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("facets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetExpressionQueryBuilderDsl.Of())),
                ProductSearchRequestQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductSearchRequestQueryBuilderDsl> Facets()
        {
            return new CollectionPredicateBuilder<ProductSearchRequestQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("facets")),
                    p => new CombinationQueryPredicate<ProductSearchRequestQueryBuilderDsl>(p, ProductSearchRequestQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductSearchRequestQueryBuilderDsl> PostFilter(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchRequestQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("postFilter"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl.Of())),
                ProductSearchRequestQueryBuilderDsl.Of);
        }


    }
}
