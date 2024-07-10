using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchWildCardExpressionQueryBuilderDsl
    {
        public SearchWildCardExpressionQueryBuilderDsl()
        {
        }

        public static SearchWildCardExpressionQueryBuilderDsl Of()
        {
            return new SearchWildCardExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SearchWildCardExpressionQueryBuilderDsl> Wildcard(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchAnyValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchAnyValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchWildCardExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("wildcard"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchAnyValueQueryBuilderDsl.Of())),
                SearchWildCardExpressionQueryBuilderDsl.Of);
        }


    }
}
