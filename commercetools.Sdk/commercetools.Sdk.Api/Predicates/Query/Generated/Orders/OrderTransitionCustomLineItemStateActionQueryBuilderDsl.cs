using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderTransitionCustomLineItemStateActionQueryBuilderDsl
    {
        public OrderTransitionCustomLineItemStateActionQueryBuilderDsl()
        {
        }

        public static OrderTransitionCustomLineItemStateActionQueryBuilderDsl Of()
        {
            return new OrderTransitionCustomLineItemStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderTransitionCustomLineItemStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderTransitionCustomLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderTransitionCustomLineItemStateActionQueryBuilderDsl>(p, OrderTransitionCustomLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderTransitionCustomLineItemStateActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<OrderTransitionCustomLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<OrderTransitionCustomLineItemStateActionQueryBuilderDsl>(p, OrderTransitionCustomLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderTransitionCustomLineItemStateActionQueryBuilderDsl, string> CustomLineItemKey()
        {
            return new ComparisonPredicateBuilder<OrderTransitionCustomLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemKey")),
            p => new CombinationQueryPredicate<OrderTransitionCustomLineItemStateActionQueryBuilderDsl>(p, OrderTransitionCustomLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderTransitionCustomLineItemStateActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<OrderTransitionCustomLineItemStateActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<OrderTransitionCustomLineItemStateActionQueryBuilderDsl>(p, OrderTransitionCustomLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderTransitionCustomLineItemStateActionQueryBuilderDsl> FromState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderTransitionCustomLineItemStateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fromState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                OrderTransitionCustomLineItemStateActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderTransitionCustomLineItemStateActionQueryBuilderDsl> ToState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderTransitionCustomLineItemStateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("toState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                OrderTransitionCustomLineItemStateActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderTransitionCustomLineItemStateActionQueryBuilderDsl, DateTime> ActualTransitionDate()
        {
            return new ComparisonPredicateBuilder<OrderTransitionCustomLineItemStateActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actualTransitionDate")),
            p => new CombinationQueryPredicate<OrderTransitionCustomLineItemStateActionQueryBuilderDsl>(p, OrderTransitionCustomLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
