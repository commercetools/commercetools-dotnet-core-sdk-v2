using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderTransitionLineItemStateActionQueryBuilderDsl
    {
        public OrderTransitionLineItemStateActionQueryBuilderDsl()
        {
        }

        public static OrderTransitionLineItemStateActionQueryBuilderDsl Of()
        {
            return new OrderTransitionLineItemStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderTransitionLineItemStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderTransitionLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderTransitionLineItemStateActionQueryBuilderDsl>(p, OrderTransitionLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderTransitionLineItemStateActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<OrderTransitionLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<OrderTransitionLineItemStateActionQueryBuilderDsl>(p, OrderTransitionLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderTransitionLineItemStateActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<OrderTransitionLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<OrderTransitionLineItemStateActionQueryBuilderDsl>(p, OrderTransitionLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderTransitionLineItemStateActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<OrderTransitionLineItemStateActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<OrderTransitionLineItemStateActionQueryBuilderDsl>(p, OrderTransitionLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderTransitionLineItemStateActionQueryBuilderDsl> FromState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderTransitionLineItemStateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fromState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                OrderTransitionLineItemStateActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderTransitionLineItemStateActionQueryBuilderDsl> ToState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderTransitionLineItemStateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("toState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                OrderTransitionLineItemStateActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderTransitionLineItemStateActionQueryBuilderDsl, DateTime> ActualTransitionDate()
        {
            return new ComparisonPredicateBuilder<OrderTransitionLineItemStateActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actualTransitionDate")),
            p => new CombinationQueryPredicate<OrderTransitionLineItemStateActionQueryBuilderDsl>(p, OrderTransitionLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
