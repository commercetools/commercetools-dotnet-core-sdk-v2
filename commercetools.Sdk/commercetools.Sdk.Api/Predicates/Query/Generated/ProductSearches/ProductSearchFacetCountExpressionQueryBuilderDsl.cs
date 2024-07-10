using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetCountExpressionQueryBuilderDsl
    {
        public ProductSearchFacetCountExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetCountExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchFacetCountExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchFacetCountExpressionQueryBuilderDsl> Count(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetCountValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetCountValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetCountExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("count"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetCountValueQueryBuilderDsl.Of())),
                ProductSearchFacetCountExpressionQueryBuilderDsl.Of);
        }


    }
}
