using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchNotExpressionQueryBuilderDsl
    {
        public ProductSearchNotExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchNotExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchNotExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchNotExpressionQueryBuilderDsl> Not(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchNotExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("not"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryQueryBuilderDsl.Of())),
                ProductSearchNotExpressionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductSearchNotExpressionQueryBuilderDsl> Not()
        {
            return new CollectionPredicateBuilder<ProductSearchNotExpressionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("not")),
                    p => new CombinationQueryPredicate<ProductSearchNotExpressionQueryBuilderDsl>(p, ProductSearchNotExpressionQueryBuilderDsl.Of));
        }

    }
}
