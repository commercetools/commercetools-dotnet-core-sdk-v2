// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderStateChangedMessagePayloadQueryBuilderDsl
    {
        public OrderStateChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderStateChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderStateChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderStateChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderStateChangedMessagePayloadQueryBuilderDsl>(p, OrderStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderStateChangedMessagePayloadQueryBuilderDsl, string> OrderState()
        {
            return new ComparisonPredicateBuilder<OrderStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderState")),
            p => new CombinationQueryPredicate<OrderStateChangedMessagePayloadQueryBuilderDsl>(p, OrderStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderStateChangedMessagePayloadQueryBuilderDsl, string> OldOrderState()
        {
            return new ComparisonPredicateBuilder<OrderStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldOrderState")),
            p => new CombinationQueryPredicate<OrderStateChangedMessagePayloadQueryBuilderDsl>(p, OrderStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
