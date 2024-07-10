using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class OrderEditAddStagedActionActionQueryBuilderDsl
    {
        public OrderEditAddStagedActionActionQueryBuilderDsl()
        {
        }

        public static OrderEditAddStagedActionActionQueryBuilderDsl Of()
        {
            return new OrderEditAddStagedActionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditAddStagedActionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderEditAddStagedActionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderEditAddStagedActionActionQueryBuilderDsl>(p, OrderEditAddStagedActionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEditAddStagedActionActionQueryBuilderDsl> StagedAction(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.StagedOrderUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.StagedOrderUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditAddStagedActionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stagedAction"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.StagedOrderUpdateActionQueryBuilderDsl.Of())),
                OrderEditAddStagedActionActionQueryBuilderDsl.Of);
        }


    }
}
