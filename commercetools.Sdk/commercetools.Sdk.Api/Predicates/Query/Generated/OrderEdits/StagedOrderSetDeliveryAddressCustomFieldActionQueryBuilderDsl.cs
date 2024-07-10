// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl
    {
        public StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string> DeliveryKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryKey")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
