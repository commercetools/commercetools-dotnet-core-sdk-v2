// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderCustomFieldChangedMessagePayloadQueryBuilderDsl
    {
        public OrderCustomFieldChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderCustomFieldChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderCustomFieldChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderCustomFieldChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderCustomFieldChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderCustomFieldChangedMessagePayloadQueryBuilderDsl>(p, OrderCustomFieldChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomFieldChangedMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<OrderCustomFieldChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<OrderCustomFieldChangedMessagePayloadQueryBuilderDsl>(p, OrderCustomFieldChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomFieldChangedMessagePayloadQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<OrderCustomFieldChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<OrderCustomFieldChangedMessagePayloadQueryBuilderDsl>(p, OrderCustomFieldChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomFieldChangedMessagePayloadQueryBuilderDsl, string> PreviousValue()
        {
            return new ComparisonPredicateBuilder<OrderCustomFieldChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("previousValue")),
            p => new CombinationQueryPredicate<OrderCustomFieldChangedMessagePayloadQueryBuilderDsl>(p, OrderCustomFieldChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
