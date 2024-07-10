using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchFullTextPrefixExpressionQueryBuilderDsl
    {
        public SearchFullTextPrefixExpressionQueryBuilderDsl()
        {
        }

        public static SearchFullTextPrefixExpressionQueryBuilderDsl Of()
        {
            return new SearchFullTextPrefixExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SearchFullTextPrefixExpressionQueryBuilderDsl> FullTextPrefix(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchFullTextPrefixValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchFullTextPrefixValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchFullTextPrefixExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fullTextPrefix"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchFullTextPrefixValueQueryBuilderDsl.Of())),
                SearchFullTextPrefixExpressionQueryBuilderDsl.Of);
        }


    }
}
