// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderShipmentStateChangedMessagePayloadQueryBuilderDsl
    {
        public OrderShipmentStateChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderShipmentStateChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderShipmentStateChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderShipmentStateChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderShipmentStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderShipmentStateChangedMessagePayloadQueryBuilderDsl>(p, OrderShipmentStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderShipmentStateChangedMessagePayloadQueryBuilderDsl, string> ShipmentState()
        {
            return new ComparisonPredicateBuilder<OrderShipmentStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipmentState")),
            p => new CombinationQueryPredicate<OrderShipmentStateChangedMessagePayloadQueryBuilderDsl>(p, OrderShipmentStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderShipmentStateChangedMessagePayloadQueryBuilderDsl, string> OldShipmentState()
        {
            return new ComparisonPredicateBuilder<OrderShipmentStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldShipmentState")),
            p => new CombinationQueryPredicate<OrderShipmentStateChangedMessagePayloadQueryBuilderDsl>(p, OrderShipmentStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
