using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchFuzzyExpressionQueryBuilderDsl
    {
        public SearchFuzzyExpressionQueryBuilderDsl()
        {
        }

        public static SearchFuzzyExpressionQueryBuilderDsl Of()
        {
            return new SearchFuzzyExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SearchFuzzyExpressionQueryBuilderDsl> Fuzzy(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchFuzzyValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchFuzzyValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchFuzzyExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fuzzy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchFuzzyValueQueryBuilderDsl.Of())),
                SearchFuzzyExpressionQueryBuilderDsl.Of);
        }


    }
}
