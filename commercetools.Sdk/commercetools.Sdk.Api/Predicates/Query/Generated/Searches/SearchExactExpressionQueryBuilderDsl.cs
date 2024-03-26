using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchExactExpressionQueryBuilderDsl
    {
        public SearchExactExpressionQueryBuilderDsl()
        {
        }

        public static SearchExactExpressionQueryBuilderDsl Of()
        {
            return new SearchExactExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SearchExactExpressionQueryBuilderDsl> Exact(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchAnyValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchAnyValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchExactExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("exact"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchAnyValueQueryBuilderDsl.Of())),
                SearchExactExpressionQueryBuilderDsl.Of);
        }


    }
}
