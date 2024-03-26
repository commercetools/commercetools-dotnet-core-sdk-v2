using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchDateRangeExpressionQueryBuilderDsl
    {
        public SearchDateRangeExpressionQueryBuilderDsl()
        {
        }

        public static SearchDateRangeExpressionQueryBuilderDsl Of()
        {
            return new SearchDateRangeExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SearchDateRangeExpressionQueryBuilderDsl> Range(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchDateRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchDateRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchDateRangeExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("range"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchDateRangeValueQueryBuilderDsl.Of())),
                SearchDateRangeExpressionQueryBuilderDsl.Of);
        }


    }
}
