using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetDistinctExpressionQueryBuilderDsl
    {
        public ProductSearchFacetDistinctExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetDistinctExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchFacetDistinctExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchFacetDistinctExpressionQueryBuilderDsl> Distinct(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetDistinctValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetDistinctValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetDistinctExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distinct"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetDistinctValueQueryBuilderDsl.Of())),
                ProductSearchFacetDistinctExpressionQueryBuilderDsl.Of);
        }


    }
}
