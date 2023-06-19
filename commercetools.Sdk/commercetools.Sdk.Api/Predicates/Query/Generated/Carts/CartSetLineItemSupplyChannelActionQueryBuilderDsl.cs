using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetLineItemSupplyChannelActionQueryBuilderDsl
    {
        public CartSetLineItemSupplyChannelActionQueryBuilderDsl()
        {
        }

        public static CartSetLineItemSupplyChannelActionQueryBuilderDsl Of()
        {
            return new CartSetLineItemSupplyChannelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetLineItemSupplyChannelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemSupplyChannelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetLineItemSupplyChannelActionQueryBuilderDsl>(p, CartSetLineItemSupplyChannelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetLineItemSupplyChannelActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemSupplyChannelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<CartSetLineItemSupplyChannelActionQueryBuilderDsl>(p, CartSetLineItemSupplyChannelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetLineItemSupplyChannelActionQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetLineItemSupplyChannelActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                CartSetLineItemSupplyChannelActionQueryBuilderDsl.Of);
        }


    }
}
