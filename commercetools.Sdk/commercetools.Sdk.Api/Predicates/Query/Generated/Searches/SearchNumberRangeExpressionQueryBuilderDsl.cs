using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchNumberRangeExpressionQueryBuilderDsl
    {
        public SearchNumberRangeExpressionQueryBuilderDsl()
        {
        }

        public static SearchNumberRangeExpressionQueryBuilderDsl Of()
        {
            return new SearchNumberRangeExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SearchNumberRangeExpressionQueryBuilderDsl> Range(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchNumberRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchNumberRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchNumberRangeExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("range"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchNumberRangeValueQueryBuilderDsl.Of())),
                SearchNumberRangeExpressionQueryBuilderDsl.Of);
        }


    }
}
