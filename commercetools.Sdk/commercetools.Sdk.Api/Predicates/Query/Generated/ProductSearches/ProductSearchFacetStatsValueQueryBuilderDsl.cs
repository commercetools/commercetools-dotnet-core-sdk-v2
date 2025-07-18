using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetStatsValueQueryBuilderDsl
    {
        public ProductSearchFacetStatsValueQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetStatsValueQueryBuilderDsl Of()
        {
            return new ProductSearchFacetStatsValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchFacetStatsValueQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetStatsValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductSearchFacetStatsValueQueryBuilderDsl>(p, ProductSearchFacetStatsValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetStatsValueQueryBuilderDsl, string> Scope()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetStatsValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("scope")),
            p => new CombinationQueryPredicate<ProductSearchFacetStatsValueQueryBuilderDsl>(p, ProductSearchFacetStatsValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSearchFacetStatsValueQueryBuilderDsl> Filter(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetStatsValueQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("filter"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl.Of())),
                ProductSearchFacetStatsValueQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductSearchFacetStatsValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetStatsValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<ProductSearchFacetStatsValueQueryBuilderDsl>(p, ProductSearchFacetStatsValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetStatsValueQueryBuilderDsl, string> FieldType()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetStatsValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldType")),
            p => new CombinationQueryPredicate<ProductSearchFacetStatsValueQueryBuilderDsl>(p, ProductSearchFacetStatsValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
