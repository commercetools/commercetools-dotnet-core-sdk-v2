using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchOrExpressionQueryBuilderDsl
    {
        public ProductSearchOrExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchOrExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchOrExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchOrExpressionQueryBuilderDsl> Or(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchOrExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("or"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryQueryBuilderDsl.Of())),
                ProductSearchOrExpressionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductSearchOrExpressionQueryBuilderDsl> Or()
        {
            return new CollectionPredicateBuilder<ProductSearchOrExpressionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("or")),
                    p => new CombinationQueryPredicate<ProductSearchOrExpressionQueryBuilderDsl>(p, ProductSearchOrExpressionQueryBuilderDsl.Of));
        }

    }
}
