using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderTransitionLineItemStateActionQueryBuilderDsl
    {
        public StagedOrderTransitionLineItemStateActionQueryBuilderDsl()
        {
        }

        public static StagedOrderTransitionLineItemStateActionQueryBuilderDsl Of()
        {
            return new StagedOrderTransitionLineItemStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderTransitionLineItemStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderTransitionLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderTransitionLineItemStateActionQueryBuilderDsl>(p, StagedOrderTransitionLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderTransitionLineItemStateActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<StagedOrderTransitionLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<StagedOrderTransitionLineItemStateActionQueryBuilderDsl>(p, StagedOrderTransitionLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderTransitionLineItemStateActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<StagedOrderTransitionLineItemStateActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<StagedOrderTransitionLineItemStateActionQueryBuilderDsl>(p, StagedOrderTransitionLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderTransitionLineItemStateActionQueryBuilderDsl> FromState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderTransitionLineItemStateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fromState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderTransitionLineItemStateActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderTransitionLineItemStateActionQueryBuilderDsl> ToState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderTransitionLineItemStateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("toState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderTransitionLineItemStateActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedOrderTransitionLineItemStateActionQueryBuilderDsl, DateTime> ActualTransitionDate()
        {
            return new ComparisonPredicateBuilder<StagedOrderTransitionLineItemStateActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actualTransitionDate")),
            p => new CombinationQueryPredicate<StagedOrderTransitionLineItemStateActionQueryBuilderDsl>(p, StagedOrderTransitionLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
