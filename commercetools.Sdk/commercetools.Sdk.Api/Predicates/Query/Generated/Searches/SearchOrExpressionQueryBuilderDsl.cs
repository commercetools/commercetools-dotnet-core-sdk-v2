using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchOrExpressionQueryBuilderDsl
    {
        public SearchOrExpressionQueryBuilderDsl()
        {
        }

        public static SearchOrExpressionQueryBuilderDsl Of()
        {
            return new SearchOrExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SearchOrExpressionQueryBuilderDsl> Or(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchOrExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("or"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl.Of())),
                SearchOrExpressionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<SearchOrExpressionQueryBuilderDsl> Or()
        {
            return new CollectionPredicateBuilder<SearchOrExpressionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("or")),
                    p => new CombinationQueryPredicate<SearchOrExpressionQueryBuilderDsl>(p, SearchOrExpressionQueryBuilderDsl.Of));
        }

    }
}
