using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchLongRangeExpressionQueryBuilderDsl
    {
        public SearchLongRangeExpressionQueryBuilderDsl()
        {
        }

        public static SearchLongRangeExpressionQueryBuilderDsl Of()
        {
            return new SearchLongRangeExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SearchLongRangeExpressionQueryBuilderDsl> Range(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchLongRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchLongRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchLongRangeExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("range"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchLongRangeValueQueryBuilderDsl.Of())),
                SearchLongRangeExpressionQueryBuilderDsl.Of);
        }


    }
}
