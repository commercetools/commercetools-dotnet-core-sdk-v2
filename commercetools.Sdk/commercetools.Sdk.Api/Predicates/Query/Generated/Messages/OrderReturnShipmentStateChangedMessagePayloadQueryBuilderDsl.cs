// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl
    {
        public OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl>(p, OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl, string> ReturnItemId()
        {
            return new ComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnItemId")),
            p => new CombinationQueryPredicate<OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl>(p, OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl, string> ReturnShipmentState()
        {
            return new ComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnShipmentState")),
            p => new CombinationQueryPredicate<OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl>(p, OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
