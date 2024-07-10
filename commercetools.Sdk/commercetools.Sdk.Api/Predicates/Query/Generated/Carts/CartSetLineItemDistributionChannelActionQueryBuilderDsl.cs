using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetLineItemDistributionChannelActionQueryBuilderDsl
    {
        public CartSetLineItemDistributionChannelActionQueryBuilderDsl()
        {
        }

        public static CartSetLineItemDistributionChannelActionQueryBuilderDsl Of()
        {
            return new CartSetLineItemDistributionChannelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetLineItemDistributionChannelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemDistributionChannelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetLineItemDistributionChannelActionQueryBuilderDsl>(p, CartSetLineItemDistributionChannelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetLineItemDistributionChannelActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemDistributionChannelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<CartSetLineItemDistributionChannelActionQueryBuilderDsl>(p, CartSetLineItemDistributionChannelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetLineItemDistributionChannelActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemDistributionChannelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<CartSetLineItemDistributionChannelActionQueryBuilderDsl>(p, CartSetLineItemDistributionChannelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetLineItemDistributionChannelActionQueryBuilderDsl> DistributionChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetLineItemDistributionChannelActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distributionChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                CartSetLineItemDistributionChannelActionQueryBuilderDsl.Of);
        }


    }
}
