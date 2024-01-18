using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchQueryExpressionQueryBuilderDsl
    {
        public ProductSearchQueryExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchQueryExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchQueryExpressionQueryBuilderDsl();
        }


        public CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl> AsProductSearchDateRangeExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchDateRangeExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchDateRangeExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchDateRangeExpressionQueryBuilderDsl.Of()),
                ProductSearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl> AsProductSearchDateTimeRangeExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchDateTimeRangeExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchDateTimeRangeExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchDateTimeRangeExpressionQueryBuilderDsl.Of()),
                ProductSearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl> AsProductSearchExactExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchExactExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchExactExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchExactExpressionQueryBuilderDsl.Of()),
                ProductSearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl> AsProductSearchExistsExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchExistsExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchExistsExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchExistsExpressionQueryBuilderDsl.Of()),
                ProductSearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl> AsProductSearchFullTextExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFullTextExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFullTextExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFullTextExpressionQueryBuilderDsl.Of()),
                ProductSearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl> AsProductSearchLongRangeExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchLongRangeExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchLongRangeExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchLongRangeExpressionQueryBuilderDsl.Of()),
                ProductSearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl> AsProductSearchNumberRangeExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchNumberRangeExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchNumberRangeExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchNumberRangeExpressionQueryBuilderDsl.Of()),
                ProductSearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl> AsProductSearchPrefixExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchPrefixExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchPrefixExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchPrefixExpressionQueryBuilderDsl.Of()),
                ProductSearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl> AsProductSearchTimeRangeExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchTimeRangeExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchTimeRangeExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchTimeRangeExpressionQueryBuilderDsl.Of()),
                ProductSearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl> AsProductSearchWildCardExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchWildCardExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchWildCardExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchWildCardExpressionQueryBuilderDsl.Of()),
                ProductSearchQueryExpressionQueryBuilderDsl.Of);
        }
    }
}
