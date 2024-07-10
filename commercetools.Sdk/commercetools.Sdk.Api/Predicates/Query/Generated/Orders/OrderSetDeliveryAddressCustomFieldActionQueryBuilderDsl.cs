// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl
    {
        public OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl()
        {
        }

        public static OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl Of()
        {
            return new OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl>(p, OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl>(p, OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string> DeliveryKey()
        {
            return new ComparisonPredicateBuilder<OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryKey")),
            p => new CombinationQueryPredicate<OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl>(p, OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl>(p, OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl>(p, OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
