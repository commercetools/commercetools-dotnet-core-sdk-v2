// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderRemoveDeliveryActionQueryBuilderDsl
    {
        public OrderRemoveDeliveryActionQueryBuilderDsl()
        {
        }

        public static OrderRemoveDeliveryActionQueryBuilderDsl Of()
        {
            return new OrderRemoveDeliveryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderRemoveDeliveryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderRemoveDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderRemoveDeliveryActionQueryBuilderDsl>(p, OrderRemoveDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderRemoveDeliveryActionQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<OrderRemoveDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<OrderRemoveDeliveryActionQueryBuilderDsl>(p, OrderRemoveDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderRemoveDeliveryActionQueryBuilderDsl, string> DeliveryKey()
        {
            return new ComparisonPredicateBuilder<OrderRemoveDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryKey")),
            p => new CombinationQueryPredicate<OrderRemoveDeliveryActionQueryBuilderDsl>(p, OrderRemoveDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
