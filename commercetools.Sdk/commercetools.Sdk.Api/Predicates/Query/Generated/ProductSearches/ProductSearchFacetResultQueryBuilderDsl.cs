using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetResultQueryBuilderDsl
    {
        public ProductSearchFacetResultQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetResultQueryBuilderDsl Of()
        {
            return new ProductSearchFacetResultQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchFacetResultQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetResultQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultExpressionQueryBuilderDsl.Of())),
                ProductSearchFacetResultQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductSearchFacetResultQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<ProductSearchFacetResultQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<ProductSearchFacetResultQueryBuilderDsl>(p, ProductSearchFacetResultQueryBuilderDsl.Of));
        }

    }
}
