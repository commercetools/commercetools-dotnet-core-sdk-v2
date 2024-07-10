using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl
    {
        public MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl()
        {
        }

        public static MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl Of()
        {
            return new MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl>(p, MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl>(p, MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl>(p, MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl> TargetsDelta(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingTargetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingTargetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("targetsDelta"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingTargetQueryBuilderDsl.Of())),
                MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl> TargetsDelta()
        {
            return new CollectionPredicateBuilder<MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("targetsDelta")),
                    p => new CombinationQueryPredicate<MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl>(p, MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl.Of));
        }

    }
}
