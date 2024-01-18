using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetDistinctValueQueryBuilderDsl
    {
        public ProductSearchFacetDistinctValueQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetDistinctValueQueryBuilderDsl Of()
        {
            return new ProductSearchFacetDistinctValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchFacetDistinctValueQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetDistinctValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductSearchFacetDistinctValueQueryBuilderDsl>(p, ProductSearchFacetDistinctValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetDistinctValueQueryBuilderDsl, string> Scope()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetDistinctValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("scope")),
            p => new CombinationQueryPredicate<ProductSearchFacetDistinctValueQueryBuilderDsl>(p, ProductSearchFacetDistinctValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSearchFacetDistinctValueQueryBuilderDsl> Filter(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetDistinctValueQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("filter"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryQueryBuilderDsl.Of())),
                ProductSearchFacetDistinctValueQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductSearchFacetDistinctValueQueryBuilderDsl, string> Count()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetDistinctValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ProductSearchFacetDistinctValueQueryBuilderDsl>(p, ProductSearchFacetDistinctValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetDistinctValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetDistinctValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<ProductSearchFacetDistinctValueQueryBuilderDsl>(p, ProductSearchFacetDistinctValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProductSearchFacetDistinctValueQueryBuilderDsl, string> Includes()
        {
            return new ComparableCollectionPredicateBuilder<ProductSearchFacetDistinctValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("includes")),
            p => new CombinationQueryPredicate<ProductSearchFacetDistinctValueQueryBuilderDsl>(p, ProductSearchFacetDistinctValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSearchFacetDistinctValueQueryBuilderDsl> StartsWith(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetDistinctStartsWithQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetDistinctStartsWithQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetDistinctValueQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("startsWith"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetDistinctStartsWithQueryBuilderDsl.Of())),
                ProductSearchFacetDistinctValueQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSearchFacetDistinctValueQueryBuilderDsl> Sort(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetDistinctBucketSortExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetDistinctBucketSortExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetDistinctValueQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("sort"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetDistinctBucketSortExpressionQueryBuilderDsl.Of())),
                ProductSearchFacetDistinctValueQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductSearchFacetDistinctValueQueryBuilderDsl, long> Size()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetDistinctValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("size")),
            p => new CombinationQueryPredicate<ProductSearchFacetDistinctValueQueryBuilderDsl>(p, ProductSearchFacetDistinctValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetDistinctValueQueryBuilderDsl, string> Language()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetDistinctValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("language")),
            p => new CombinationQueryPredicate<ProductSearchFacetDistinctValueQueryBuilderDsl>(p, ProductSearchFacetDistinctValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetDistinctValueQueryBuilderDsl, string> AttributeType()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetDistinctValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeType")),
            p => new CombinationQueryPredicate<ProductSearchFacetDistinctValueQueryBuilderDsl>(p, ProductSearchFacetDistinctValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetDistinctValueQueryBuilderDsl, string> Missing()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetDistinctValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("missing")),
            p => new CombinationQueryPredicate<ProductSearchFacetDistinctValueQueryBuilderDsl>(p, ProductSearchFacetDistinctValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
