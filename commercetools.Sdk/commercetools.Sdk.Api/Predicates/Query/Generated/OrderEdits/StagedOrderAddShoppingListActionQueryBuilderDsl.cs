using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderAddShoppingListActionQueryBuilderDsl
    {
        public StagedOrderAddShoppingListActionQueryBuilderDsl()
        {
        }

        public static StagedOrderAddShoppingListActionQueryBuilderDsl Of()
        {
            return new StagedOrderAddShoppingListActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderAddShoppingListActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddShoppingListActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderAddShoppingListActionQueryBuilderDsl>(p, StagedOrderAddShoppingListActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderAddShoppingListActionQueryBuilderDsl> ShoppingList(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddShoppingListActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shoppingList"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderAddShoppingListActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderAddShoppingListActionQueryBuilderDsl> DistributionChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddShoppingListActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distributionChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderAddShoppingListActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderAddShoppingListActionQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddShoppingListActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderAddShoppingListActionQueryBuilderDsl.Of);
        }


    }
}
