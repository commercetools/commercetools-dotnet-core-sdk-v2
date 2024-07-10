// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderCustomTypeRemovedMessagePayloadQueryBuilderDsl
    {
        public OrderCustomTypeRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderCustomTypeRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderCustomTypeRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderCustomTypeRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderCustomTypeRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderCustomTypeRemovedMessagePayloadQueryBuilderDsl>(p, OrderCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomTypeRemovedMessagePayloadQueryBuilderDsl, string> PreviousTypeId()
        {
            return new ComparisonPredicateBuilder<OrderCustomTypeRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("previousTypeId")),
            p => new CombinationQueryPredicate<OrderCustomTypeRemovedMessagePayloadQueryBuilderDsl>(p, OrderCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
