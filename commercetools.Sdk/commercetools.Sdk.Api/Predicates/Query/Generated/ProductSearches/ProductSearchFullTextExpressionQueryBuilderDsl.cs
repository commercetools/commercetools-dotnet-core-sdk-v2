using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFullTextExpressionQueryBuilderDsl
    {
        public ProductSearchFullTextExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchFullTextExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchFullTextExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchFullTextExpressionQueryBuilderDsl> FullText(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFullTextValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFullTextValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFullTextExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fullText"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFullTextValueQueryBuilderDsl.Of())),
                ProductSearchFullTextExpressionQueryBuilderDsl.Of);
        }


    }
}
