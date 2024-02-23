using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class OrderEditSetStagedActionsActionQueryBuilderDsl
    {
        public OrderEditSetStagedActionsActionQueryBuilderDsl()
        {
        }

        public static OrderEditSetStagedActionsActionQueryBuilderDsl Of()
        {
            return new OrderEditSetStagedActionsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditSetStagedActionsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderEditSetStagedActionsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderEditSetStagedActionsActionQueryBuilderDsl>(p, OrderEditSetStagedActionsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEditSetStagedActionsActionQueryBuilderDsl> StagedActions(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.StagedOrderUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.StagedOrderUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditSetStagedActionsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stagedActions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.StagedOrderUpdateActionQueryBuilderDsl.Of())),
                OrderEditSetStagedActionsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderEditSetStagedActionsActionQueryBuilderDsl> StagedActions()
        {
            return new CollectionPredicateBuilder<OrderEditSetStagedActionsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stagedActions")),
                    p => new CombinationQueryPredicate<OrderEditSetStagedActionsActionQueryBuilderDsl>(p, OrderEditSetStagedActionsActionQueryBuilderDsl.Of));
        }

    }
}
