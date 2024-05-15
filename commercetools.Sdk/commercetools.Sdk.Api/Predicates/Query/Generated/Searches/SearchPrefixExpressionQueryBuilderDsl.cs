using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchPrefixExpressionQueryBuilderDsl
    {
        public SearchPrefixExpressionQueryBuilderDsl()
        {
        }

        public static SearchPrefixExpressionQueryBuilderDsl Of()
        {
            return new SearchPrefixExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SearchPrefixExpressionQueryBuilderDsl> Prefix(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchAnyValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchAnyValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchPrefixExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("prefix"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchAnyValueQueryBuilderDsl.Of())),
                SearchPrefixExpressionQueryBuilderDsl.Of);
        }


    }
}
