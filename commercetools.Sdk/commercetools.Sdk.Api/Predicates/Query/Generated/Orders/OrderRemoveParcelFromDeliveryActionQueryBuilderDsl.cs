// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderRemoveParcelFromDeliveryActionQueryBuilderDsl
    {
        public OrderRemoveParcelFromDeliveryActionQueryBuilderDsl()
        {
        }

        public static OrderRemoveParcelFromDeliveryActionQueryBuilderDsl Of()
        {
            return new OrderRemoveParcelFromDeliveryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderRemoveParcelFromDeliveryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderRemoveParcelFromDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderRemoveParcelFromDeliveryActionQueryBuilderDsl>(p, OrderRemoveParcelFromDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderRemoveParcelFromDeliveryActionQueryBuilderDsl, string> ParcelId()
        {
            return new ComparisonPredicateBuilder<OrderRemoveParcelFromDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelId")),
            p => new CombinationQueryPredicate<OrderRemoveParcelFromDeliveryActionQueryBuilderDsl>(p, OrderRemoveParcelFromDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderRemoveParcelFromDeliveryActionQueryBuilderDsl, string> ParcelKey()
        {
            return new ComparisonPredicateBuilder<OrderRemoveParcelFromDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelKey")),
            p => new CombinationQueryPredicate<OrderRemoveParcelFromDeliveryActionQueryBuilderDsl>(p, OrderRemoveParcelFromDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
