// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderChangeShipmentStateActionQueryBuilderDsl
    {
        public OrderChangeShipmentStateActionQueryBuilderDsl()
        {
        }

        public static OrderChangeShipmentStateActionQueryBuilderDsl Of()
        {
            return new OrderChangeShipmentStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderChangeShipmentStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderChangeShipmentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderChangeShipmentStateActionQueryBuilderDsl>(p, OrderChangeShipmentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderChangeShipmentStateActionQueryBuilderDsl, string> ShipmentState()
        {
            return new ComparisonPredicateBuilder<OrderChangeShipmentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipmentState")),
            p => new CombinationQueryPredicate<OrderChangeShipmentStateActionQueryBuilderDsl>(p, OrderChangeShipmentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
