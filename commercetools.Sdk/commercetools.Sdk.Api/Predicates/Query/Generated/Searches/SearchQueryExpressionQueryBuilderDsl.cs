using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchQueryExpressionQueryBuilderDsl
    {
        public SearchQueryExpressionQueryBuilderDsl()
        {
        }

        public static SearchQueryExpressionQueryBuilderDsl Of()
        {
            return new SearchQueryExpressionQueryBuilderDsl();
        }


        public CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl> AsSearchDateRangeExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchDateRangeExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchDateRangeExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchDateRangeExpressionQueryBuilderDsl.Of()),
                SearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl> AsSearchDateTimeRangeExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchDateTimeRangeExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchDateTimeRangeExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchDateTimeRangeExpressionQueryBuilderDsl.Of()),
                SearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl> AsSearchExactExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchExactExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchExactExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchExactExpressionQueryBuilderDsl.Of()),
                SearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl> AsSearchExistsExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchExistsExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchExistsExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchExistsExpressionQueryBuilderDsl.Of()),
                SearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl> AsSearchFullTextExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchFullTextExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchFullTextExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchFullTextExpressionQueryBuilderDsl.Of()),
                SearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl> AsSearchFullTextPrefixExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchFullTextPrefixExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchFullTextPrefixExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchFullTextPrefixExpressionQueryBuilderDsl.Of()),
                SearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl> AsSearchLongRangeExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchLongRangeExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchLongRangeExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchLongRangeExpressionQueryBuilderDsl.Of()),
                SearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl> AsSearchNumberRangeExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchNumberRangeExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchNumberRangeExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchNumberRangeExpressionQueryBuilderDsl.Of()),
                SearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl> AsSearchPrefixExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchPrefixExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchPrefixExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchPrefixExpressionQueryBuilderDsl.Of()),
                SearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl> AsSearchTimeRangeExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchTimeRangeExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchTimeRangeExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchTimeRangeExpressionQueryBuilderDsl.Of()),
                SearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl> AsSearchWildCardExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchWildCardExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchWildCardExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchWildCardExpressionQueryBuilderDsl.Of()),
                SearchQueryExpressionQueryBuilderDsl.Of);
        }
    }
}
