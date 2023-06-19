using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class LineItemStateTransitionMessagePayloadQueryBuilderDsl
    {
        public LineItemStateTransitionMessagePayloadQueryBuilderDsl()
        {
        }

        public static LineItemStateTransitionMessagePayloadQueryBuilderDsl Of()
        {
            return new LineItemStateTransitionMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<LineItemStateTransitionMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<LineItemStateTransitionMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<LineItemStateTransitionMessagePayloadQueryBuilderDsl>(p, LineItemStateTransitionMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemStateTransitionMessagePayloadQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<LineItemStateTransitionMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<LineItemStateTransitionMessagePayloadQueryBuilderDsl>(p, LineItemStateTransitionMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemStateTransitionMessagePayloadQueryBuilderDsl, DateTime> TransitionDate()
        {
            return new ComparisonPredicateBuilder<LineItemStateTransitionMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transitionDate")),
            p => new CombinationQueryPredicate<LineItemStateTransitionMessagePayloadQueryBuilderDsl>(p, LineItemStateTransitionMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemStateTransitionMessagePayloadQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<LineItemStateTransitionMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<LineItemStateTransitionMessagePayloadQueryBuilderDsl>(p, LineItemStateTransitionMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<LineItemStateTransitionMessagePayloadQueryBuilderDsl> FromState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemStateTransitionMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fromState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                LineItemStateTransitionMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<LineItemStateTransitionMessagePayloadQueryBuilderDsl> ToState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemStateTransitionMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("toState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                LineItemStateTransitionMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
