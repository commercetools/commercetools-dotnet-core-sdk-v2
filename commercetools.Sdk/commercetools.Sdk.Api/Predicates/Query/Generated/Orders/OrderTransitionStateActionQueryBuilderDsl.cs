using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderTransitionStateActionQueryBuilderDsl
    {
        public OrderTransitionStateActionQueryBuilderDsl()
        {
        }

        public static OrderTransitionStateActionQueryBuilderDsl Of()
        {
            return new OrderTransitionStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderTransitionStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderTransitionStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderTransitionStateActionQueryBuilderDsl>(p, OrderTransitionStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderTransitionStateActionQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderTransitionStateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                OrderTransitionStateActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderTransitionStateActionQueryBuilderDsl, bool> Force()
        {
            return new ComparisonPredicateBuilder<OrderTransitionStateActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("force")),
            p => new CombinationQueryPredicate<OrderTransitionStateActionQueryBuilderDsl>(p, OrderTransitionStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
