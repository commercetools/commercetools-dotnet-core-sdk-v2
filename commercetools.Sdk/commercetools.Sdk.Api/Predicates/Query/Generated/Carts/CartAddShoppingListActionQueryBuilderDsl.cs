using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartAddShoppingListActionQueryBuilderDsl
    {
        public CartAddShoppingListActionQueryBuilderDsl()
        {
        }

        public static CartAddShoppingListActionQueryBuilderDsl Of()
        {
            return new CartAddShoppingListActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartAddShoppingListActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartAddShoppingListActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartAddShoppingListActionQueryBuilderDsl>(p, CartAddShoppingListActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartAddShoppingListActionQueryBuilderDsl> ShoppingList(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartAddShoppingListActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shoppingList"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListResourceIdentifierQueryBuilderDsl.Of())),
                CartAddShoppingListActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartAddShoppingListActionQueryBuilderDsl> DistributionChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartAddShoppingListActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distributionChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                CartAddShoppingListActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartAddShoppingListActionQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartAddShoppingListActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                CartAddShoppingListActionQueryBuilderDsl.Of);
        }


    }
}
