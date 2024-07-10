using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetReturnShipmentStateActionQueryBuilderDsl
    {
        public OrderSetReturnShipmentStateActionQueryBuilderDsl()
        {
        }

        public static OrderSetReturnShipmentStateActionQueryBuilderDsl Of()
        {
            return new OrderSetReturnShipmentStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetReturnShipmentStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetReturnShipmentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetReturnShipmentStateActionQueryBuilderDsl>(p, OrderSetReturnShipmentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetReturnShipmentStateActionQueryBuilderDsl, string> ReturnItemId()
        {
            return new ComparisonPredicateBuilder<OrderSetReturnShipmentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnItemId")),
            p => new CombinationQueryPredicate<OrderSetReturnShipmentStateActionQueryBuilderDsl>(p, OrderSetReturnShipmentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetReturnShipmentStateActionQueryBuilderDsl, string> ReturnItemKey()
        {
            return new ComparisonPredicateBuilder<OrderSetReturnShipmentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnItemKey")),
            p => new CombinationQueryPredicate<OrderSetReturnShipmentStateActionQueryBuilderDsl>(p, OrderSetReturnShipmentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetReturnShipmentStateActionQueryBuilderDsl, string> ShipmentState()
        {
            return new ComparisonPredicateBuilder<OrderSetReturnShipmentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipmentState")),
            p => new CombinationQueryPredicate<OrderSetReturnShipmentStateActionQueryBuilderDsl>(p, OrderSetReturnShipmentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
