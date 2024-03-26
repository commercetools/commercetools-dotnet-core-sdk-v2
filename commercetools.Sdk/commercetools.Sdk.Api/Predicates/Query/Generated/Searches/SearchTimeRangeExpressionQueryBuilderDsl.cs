using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchTimeRangeExpressionQueryBuilderDsl
    {
        public SearchTimeRangeExpressionQueryBuilderDsl()
        {
        }

        public static SearchTimeRangeExpressionQueryBuilderDsl Of()
        {
            return new SearchTimeRangeExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SearchTimeRangeExpressionQueryBuilderDsl> Range(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchTimeRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchTimeRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchTimeRangeExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("range"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchTimeRangeValueQueryBuilderDsl.Of())),
                SearchTimeRangeExpressionQueryBuilderDsl.Of);
        }


    }
}
