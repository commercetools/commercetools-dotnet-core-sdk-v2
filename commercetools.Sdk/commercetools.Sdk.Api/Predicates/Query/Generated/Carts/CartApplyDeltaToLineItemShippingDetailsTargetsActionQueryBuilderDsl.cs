using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl
    {
        public CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl()
        {
        }

        public static CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl Of()
        {
            return new CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl>(p, CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl>(p, CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl>(p, CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl> TargetsDelta(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingTargetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingTargetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("targetsDelta"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingTargetQueryBuilderDsl.Of())),
                CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl> TargetsDelta()
        {
            return new CollectionPredicateBuilder<CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("targetsDelta")),
                    p => new CombinationQueryPredicate<CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl>(p, CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl.Of));
        }

    }
}
