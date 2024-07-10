// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderPaymentStateChangedMessagePayloadQueryBuilderDsl
    {
        public OrderPaymentStateChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderPaymentStateChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderPaymentStateChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderPaymentStateChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderPaymentStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderPaymentStateChangedMessagePayloadQueryBuilderDsl>(p, OrderPaymentStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPaymentStateChangedMessagePayloadQueryBuilderDsl, string> PaymentState()
        {
            return new ComparisonPredicateBuilder<OrderPaymentStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentState")),
            p => new CombinationQueryPredicate<OrderPaymentStateChangedMessagePayloadQueryBuilderDsl>(p, OrderPaymentStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPaymentStateChangedMessagePayloadQueryBuilderDsl, string> OldPaymentState()
        {
            return new ComparisonPredicateBuilder<OrderPaymentStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldPaymentState")),
            p => new CombinationQueryPredicate<OrderPaymentStateChangedMessagePayloadQueryBuilderDsl>(p, OrderPaymentStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
