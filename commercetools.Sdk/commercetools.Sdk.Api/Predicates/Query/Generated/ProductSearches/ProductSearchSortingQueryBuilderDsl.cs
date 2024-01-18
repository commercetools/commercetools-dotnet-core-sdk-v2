using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchSortingQueryBuilderDsl
    {
        public ProductSearchSortingQueryBuilderDsl()
        {
        }

        public static ProductSearchSortingQueryBuilderDsl Of()
        {
            return new ProductSearchSortingQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchSortingQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<ProductSearchSortingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<ProductSearchSortingQueryBuilderDsl>(p, ProductSearchSortingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchSortingQueryBuilderDsl, string> Language()
        {
            return new ComparisonPredicateBuilder<ProductSearchSortingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("language")),
            p => new CombinationQueryPredicate<ProductSearchSortingQueryBuilderDsl>(p, ProductSearchSortingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchSortingQueryBuilderDsl, string> Order()
        {
            return new ComparisonPredicateBuilder<ProductSearchSortingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("order")),
            p => new CombinationQueryPredicate<ProductSearchSortingQueryBuilderDsl>(p, ProductSearchSortingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchSortingQueryBuilderDsl, string> Mode()
        {
            return new ComparisonPredicateBuilder<ProductSearchSortingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("mode")),
            p => new CombinationQueryPredicate<ProductSearchSortingQueryBuilderDsl>(p, ProductSearchSortingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchSortingQueryBuilderDsl, string> AttributeType()
        {
            return new ComparisonPredicateBuilder<ProductSearchSortingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeType")),
            p => new CombinationQueryPredicate<ProductSearchSortingQueryBuilderDsl>(p, ProductSearchSortingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSearchSortingQueryBuilderDsl> Filter(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchSortingQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("filter"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryExpressionQueryBuilderDsl.Of())),
                ProductSearchSortingQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductSearchSortingQueryBuilderDsl, bool> Internal()
        {
            return new ComparisonPredicateBuilder<ProductSearchSortingQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("internal")),
            p => new CombinationQueryPredicate<ProductSearchSortingQueryBuilderDsl>(p, ProductSearchSortingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
