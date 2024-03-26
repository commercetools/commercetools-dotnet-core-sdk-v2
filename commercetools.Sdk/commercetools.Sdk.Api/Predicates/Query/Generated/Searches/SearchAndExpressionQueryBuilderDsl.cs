using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchAndExpressionQueryBuilderDsl
    {
        public SearchAndExpressionQueryBuilderDsl()
        {
        }

        public static SearchAndExpressionQueryBuilderDsl Of()
        {
            return new SearchAndExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SearchAndExpressionQueryBuilderDsl> And(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchAndExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("and"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl.Of())),
                SearchAndExpressionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<SearchAndExpressionQueryBuilderDsl> And()
        {
            return new CollectionPredicateBuilder<SearchAndExpressionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("and")),
                    p => new CombinationQueryPredicate<SearchAndExpressionQueryBuilderDsl>(p, SearchAndExpressionQueryBuilderDsl.Of));
        }

    }
}
