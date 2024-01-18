using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetRangesValueQueryBuilderDsl
    {
        public ProductSearchFacetRangesValueQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetRangesValueQueryBuilderDsl Of()
        {
            return new ProductSearchFacetRangesValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchFacetRangesValueQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetRangesValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductSearchFacetRangesValueQueryBuilderDsl>(p, ProductSearchFacetRangesValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetRangesValueQueryBuilderDsl, string> Scope()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetRangesValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("scope")),
            p => new CombinationQueryPredicate<ProductSearchFacetRangesValueQueryBuilderDsl>(p, ProductSearchFacetRangesValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSearchFacetRangesValueQueryBuilderDsl> Filter(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetRangesValueQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("filter"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryQueryBuilderDsl.Of())),
                ProductSearchFacetRangesValueQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductSearchFacetRangesValueQueryBuilderDsl, string> Count()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetRangesValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ProductSearchFacetRangesValueQueryBuilderDsl>(p, ProductSearchFacetRangesValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetRangesValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetRangesValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<ProductSearchFacetRangesValueQueryBuilderDsl>(p, ProductSearchFacetRangesValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSearchFacetRangesValueQueryBuilderDsl> Ranges(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetRangesFacetRangeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetRangesFacetRangeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetRangesValueQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("ranges"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetRangesFacetRangeQueryBuilderDsl.Of())),
                ProductSearchFacetRangesValueQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductSearchFacetRangesValueQueryBuilderDsl> Ranges()
        {
            return new CollectionPredicateBuilder<ProductSearchFacetRangesValueQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("ranges")),
                    p => new CombinationQueryPredicate<ProductSearchFacetRangesValueQueryBuilderDsl>(p, ProductSearchFacetRangesValueQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ProductSearchFacetRangesValueQueryBuilderDsl, string> Language()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetRangesValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("language")),
            p => new CombinationQueryPredicate<ProductSearchFacetRangesValueQueryBuilderDsl>(p, ProductSearchFacetRangesValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetRangesValueQueryBuilderDsl, string> AttributeType()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetRangesValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeType")),
            p => new CombinationQueryPredicate<ProductSearchFacetRangesValueQueryBuilderDsl>(p, ProductSearchFacetRangesValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
