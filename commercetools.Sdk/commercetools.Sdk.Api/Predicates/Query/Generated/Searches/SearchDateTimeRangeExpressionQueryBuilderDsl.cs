using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchDateTimeRangeExpressionQueryBuilderDsl
    {
        public SearchDateTimeRangeExpressionQueryBuilderDsl()
        {
        }

        public static SearchDateTimeRangeExpressionQueryBuilderDsl Of()
        {
            return new SearchDateTimeRangeExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SearchDateTimeRangeExpressionQueryBuilderDsl> Range(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchDateTimeRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchDateTimeRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchDateTimeRangeExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("range"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchDateTimeRangeValueQueryBuilderDsl.Of())),
                SearchDateTimeRangeExpressionQueryBuilderDsl.Of);
        }


    }
}
