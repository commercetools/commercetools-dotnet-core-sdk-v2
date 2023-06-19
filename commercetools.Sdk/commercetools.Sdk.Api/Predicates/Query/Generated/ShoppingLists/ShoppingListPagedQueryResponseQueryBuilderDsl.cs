using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListPagedQueryResponseQueryBuilderDsl
    {
        public ShoppingListPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static ShoppingListPagedQueryResponseQueryBuilderDsl Of()
        {
            return new ShoppingListPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<ShoppingListPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<ShoppingListPagedQueryResponseQueryBuilderDsl>(p, ShoppingListPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ShoppingListPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ShoppingListPagedQueryResponseQueryBuilderDsl>(p, ShoppingListPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<ShoppingListPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<ShoppingListPagedQueryResponseQueryBuilderDsl>(p, ShoppingListPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<ShoppingListPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<ShoppingListPagedQueryResponseQueryBuilderDsl>(p, ShoppingListPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListQueryBuilderDsl.Of())),
                ShoppingListPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ShoppingListPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<ShoppingListPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<ShoppingListPagedQueryResponseQueryBuilderDsl>(p, ShoppingListPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
