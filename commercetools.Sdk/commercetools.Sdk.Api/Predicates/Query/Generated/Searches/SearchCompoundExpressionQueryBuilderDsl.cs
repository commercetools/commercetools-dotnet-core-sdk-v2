using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchCompoundExpressionQueryBuilderDsl
    {
        public SearchCompoundExpressionQueryBuilderDsl()
        {
        }

        public static SearchCompoundExpressionQueryBuilderDsl Of()
        {
            return new SearchCompoundExpressionQueryBuilderDsl();
        }


        public CombinationQueryPredicate<SearchCompoundExpressionQueryBuilderDsl> AsSearchAndExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchAndExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchAndExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchCompoundExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchAndExpressionQueryBuilderDsl.Of()),
                SearchCompoundExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchCompoundExpressionQueryBuilderDsl> AsSearchFilterExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchFilterExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchFilterExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchCompoundExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchFilterExpressionQueryBuilderDsl.Of()),
                SearchCompoundExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchCompoundExpressionQueryBuilderDsl> AsSearchNotExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchNotExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchNotExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchCompoundExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchNotExpressionQueryBuilderDsl.Of()),
                SearchCompoundExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchCompoundExpressionQueryBuilderDsl> AsSearchOrExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchOrExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchOrExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchCompoundExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchOrExpressionQueryBuilderDsl.Of()),
                SearchCompoundExpressionQueryBuilderDsl.Of);
        }
    }
}
