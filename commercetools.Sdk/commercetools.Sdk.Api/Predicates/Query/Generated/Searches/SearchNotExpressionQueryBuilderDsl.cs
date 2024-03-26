using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchNotExpressionQueryBuilderDsl
    {
        public SearchNotExpressionQueryBuilderDsl()
        {
        }

        public static SearchNotExpressionQueryBuilderDsl Of()
        {
            return new SearchNotExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SearchNotExpressionQueryBuilderDsl> Not(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchNotExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("not"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl.Of())),
                SearchNotExpressionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<SearchNotExpressionQueryBuilderDsl> Not()
        {
            return new CollectionPredicateBuilder<SearchNotExpressionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("not")),
                    p => new CombinationQueryPredicate<SearchNotExpressionQueryBuilderDsl>(p, SearchNotExpressionQueryBuilderDsl.Of));
        }

    }
}
