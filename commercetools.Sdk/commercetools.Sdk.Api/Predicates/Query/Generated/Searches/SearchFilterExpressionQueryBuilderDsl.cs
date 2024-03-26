using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchFilterExpressionQueryBuilderDsl
    {
        public SearchFilterExpressionQueryBuilderDsl()
        {
        }

        public static SearchFilterExpressionQueryBuilderDsl Of()
        {
            return new SearchFilterExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SearchFilterExpressionQueryBuilderDsl> Filter(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchFilterExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("filter"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryExpressionQueryBuilderDsl.Of())),
                SearchFilterExpressionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<SearchFilterExpressionQueryBuilderDsl> Filter()
        {
            return new CollectionPredicateBuilder<SearchFilterExpressionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("filter")),
                    p => new CombinationQueryPredicate<SearchFilterExpressionQueryBuilderDsl>(p, SearchFilterExpressionQueryBuilderDsl.Of));
        }

    }
}
