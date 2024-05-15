using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchFullTextExpressionQueryBuilderDsl
    {
        public SearchFullTextExpressionQueryBuilderDsl()
        {
        }

        public static SearchFullTextExpressionQueryBuilderDsl Of()
        {
            return new SearchFullTextExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SearchFullTextExpressionQueryBuilderDsl> FullText(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchFullTextValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchFullTextValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchFullTextExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fullText"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchFullTextValueQueryBuilderDsl.Of())),
                SearchFullTextExpressionQueryBuilderDsl.Of);
        }


    }
}
