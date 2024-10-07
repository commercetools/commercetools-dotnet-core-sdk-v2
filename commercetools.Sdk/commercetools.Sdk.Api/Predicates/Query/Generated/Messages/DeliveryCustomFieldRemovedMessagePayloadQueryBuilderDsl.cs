// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DeliveryCustomFieldRemovedMessagePayloadQueryBuilderDsl
    {
        public DeliveryCustomFieldRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static DeliveryCustomFieldRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new DeliveryCustomFieldRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DeliveryCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DeliveryCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DeliveryCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, DeliveryCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DeliveryCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<DeliveryCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<DeliveryCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, DeliveryCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DeliveryCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<DeliveryCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<DeliveryCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, DeliveryCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
