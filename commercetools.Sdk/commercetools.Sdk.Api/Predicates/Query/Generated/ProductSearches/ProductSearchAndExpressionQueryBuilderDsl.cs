using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchAndExpressionQueryBuilderDsl
    {
        public ProductSearchAndExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchAndExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchAndExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchAndExpressionQueryBuilderDsl> And(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchAndExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("and"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryQueryBuilderDsl.Of())),
                ProductSearchAndExpressionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductSearchAndExpressionQueryBuilderDsl> And()
        {
            return new CollectionPredicateBuilder<ProductSearchAndExpressionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("and")),
                    p => new CombinationQueryPredicate<ProductSearchAndExpressionQueryBuilderDsl>(p, ProductSearchAndExpressionQueryBuilderDsl.Of));
        }

    }
}
