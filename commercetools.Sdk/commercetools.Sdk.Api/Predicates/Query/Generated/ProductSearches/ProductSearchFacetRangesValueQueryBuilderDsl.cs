using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

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
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetRangesValueQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("filter"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl.Of())),
                ProductSearchFacetRangesValueQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductSearchFacetRangesValueQueryBuilderDsl, string> Level()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetRangesValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("level")),
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
        public IComparisonPredicateBuilder<ProductSearchFacetRangesValueQueryBuilderDsl, string> FieldType()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetRangesValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldType")),
            p => new CombinationQueryPredicate<ProductSearchFacetRangesValueQueryBuilderDsl>(p, ProductSearchFacetRangesValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
