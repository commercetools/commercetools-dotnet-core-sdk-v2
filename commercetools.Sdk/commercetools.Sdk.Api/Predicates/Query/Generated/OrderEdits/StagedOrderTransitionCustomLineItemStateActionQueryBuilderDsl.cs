using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl
    {
        public StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl()
        {
        }

        public static StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl Of()
        {
            return new StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl>(p, StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl>(p, StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl, string> CustomLineItemKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemKey")),
            p => new CombinationQueryPredicate<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl>(p, StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl>(p, StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl> FromState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fromState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl> ToState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("toState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl, DateTime> ActualTransitionDate()
        {
            return new ComparisonPredicateBuilder<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actualTransitionDate")),
            p => new CombinationQueryPredicate<StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl>(p, StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
