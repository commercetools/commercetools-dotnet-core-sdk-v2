// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl
    {
        public StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl, string> DeliveryKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryKey")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
