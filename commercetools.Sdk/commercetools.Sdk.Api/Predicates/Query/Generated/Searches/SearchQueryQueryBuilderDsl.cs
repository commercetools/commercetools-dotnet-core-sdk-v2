using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchQueryQueryBuilderDsl
    {
        public SearchQueryQueryBuilderDsl()
        {
        }

        public static SearchQueryQueryBuilderDsl Of()
        {
            return new SearchQueryQueryBuilderDsl();
        }


        public CombinationQueryPredicate<SearchQueryQueryBuilderDsl> AsSearchCompoundExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchCompoundExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchCompoundExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchCompoundExpressionQueryBuilderDsl.Of()),
                SearchQueryQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryQueryBuilderDsl> AsSearchQueryExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryExpressionQueryBuilderDsl.Of()),
                SearchQueryQueryBuilderDsl.Of);
        }
    }
}
