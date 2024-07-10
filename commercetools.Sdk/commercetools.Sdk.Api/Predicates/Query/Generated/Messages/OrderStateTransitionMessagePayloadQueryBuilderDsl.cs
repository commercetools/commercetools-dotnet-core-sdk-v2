using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderStateTransitionMessagePayloadQueryBuilderDsl
    {
        public OrderStateTransitionMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderStateTransitionMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderStateTransitionMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderStateTransitionMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderStateTransitionMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderStateTransitionMessagePayloadQueryBuilderDsl>(p, OrderStateTransitionMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderStateTransitionMessagePayloadQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderStateTransitionMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                OrderStateTransitionMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderStateTransitionMessagePayloadQueryBuilderDsl> OldState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderStateTransitionMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                OrderStateTransitionMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderStateTransitionMessagePayloadQueryBuilderDsl, bool> Force()
        {
            return new ComparisonPredicateBuilder<OrderStateTransitionMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("force")),
            p => new CombinationQueryPredicate<OrderStateTransitionMessagePayloadQueryBuilderDsl>(p, OrderStateTransitionMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
