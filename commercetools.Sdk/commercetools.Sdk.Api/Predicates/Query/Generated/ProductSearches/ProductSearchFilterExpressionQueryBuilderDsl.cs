using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFilterExpressionQueryBuilderDsl
    {
        public ProductSearchFilterExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchFilterExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchFilterExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchFilterExpressionQueryBuilderDsl> Filter(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFilterExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("filter"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryExpressionQueryBuilderDsl.Of())),
                ProductSearchFilterExpressionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductSearchFilterExpressionQueryBuilderDsl> Filter()
        {
            return new CollectionPredicateBuilder<ProductSearchFilterExpressionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("filter")),
                    p => new CombinationQueryPredicate<ProductSearchFilterExpressionQueryBuilderDsl>(p, ProductSearchFilterExpressionQueryBuilderDsl.Of));
        }

    }
}
