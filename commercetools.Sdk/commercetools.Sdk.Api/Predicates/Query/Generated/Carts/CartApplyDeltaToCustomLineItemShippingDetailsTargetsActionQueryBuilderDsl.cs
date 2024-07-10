using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl
    {
        public CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl()
        {
        }

        public static CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl Of()
        {
            return new CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl>(p, CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl>(p, CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl, string> CustomLineItemKey()
        {
            return new ComparisonPredicateBuilder<CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemKey")),
            p => new CombinationQueryPredicate<CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl>(p, CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl> TargetsDelta(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingTargetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingTargetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("targetsDelta"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingTargetQueryBuilderDsl.Of())),
                CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl> TargetsDelta()
        {
            return new CollectionPredicateBuilder<CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("targetsDelta")),
                    p => new CombinationQueryPredicate<CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl>(p, CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl.Of));
        }

    }
}
