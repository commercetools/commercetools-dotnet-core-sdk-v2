// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl
    {
        public OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl>(p, OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl>(p, OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl>(p, OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl, long> OldQuantity()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldQuantity")),
            p => new CombinationQueryPredicate<OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl>(p, OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
