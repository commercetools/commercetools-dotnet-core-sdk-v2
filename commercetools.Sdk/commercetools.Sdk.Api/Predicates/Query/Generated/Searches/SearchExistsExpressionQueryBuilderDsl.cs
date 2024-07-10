using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchExistsExpressionQueryBuilderDsl
    {
        public SearchExistsExpressionQueryBuilderDsl()
        {
        }

        public static SearchExistsExpressionQueryBuilderDsl Of()
        {
            return new SearchExistsExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SearchExistsExpressionQueryBuilderDsl> Exists(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchExistsValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchExistsValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchExistsExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("exists"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchExistsValueQueryBuilderDsl.Of())),
                SearchExistsExpressionQueryBuilderDsl.Of);
        }


    }
}
