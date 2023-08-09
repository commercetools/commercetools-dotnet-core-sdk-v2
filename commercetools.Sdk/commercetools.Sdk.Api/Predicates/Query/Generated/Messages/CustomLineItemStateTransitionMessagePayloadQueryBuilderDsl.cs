using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl
    {
        public CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl>(p, CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl>(p, CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl, string> CustomLineItemKey()
        {
            return new ComparisonPredicateBuilder<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemKey")),
            p => new CombinationQueryPredicate<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl>(p, CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl, DateTime> TransitionDate()
        {
            return new ComparisonPredicateBuilder<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transitionDate")),
            p => new CombinationQueryPredicate<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl>(p, CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl>(p, CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl> FromState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fromState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl> ToState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("toState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
