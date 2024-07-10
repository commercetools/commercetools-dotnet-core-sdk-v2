using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListUpdateQueryBuilderDsl
    {
        public ShoppingListUpdateQueryBuilderDsl()
        {
        }

        public static ShoppingListUpdateQueryBuilderDsl Of()
        {
            return new ShoppingListUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ShoppingListUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ShoppingListUpdateQueryBuilderDsl>(p, ShoppingListUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListUpdateActionQueryBuilderDsl.Of())),
                ShoppingListUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ShoppingListUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<ShoppingListUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<ShoppingListUpdateQueryBuilderDsl>(p, ShoppingListUpdateQueryBuilderDsl.Of));
        }

    }
}
