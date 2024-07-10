// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetShippingCustomFieldActionQueryBuilderDsl
    {
        public OrderSetShippingCustomFieldActionQueryBuilderDsl()
        {
        }

        public static OrderSetShippingCustomFieldActionQueryBuilderDsl Of()
        {
            return new OrderSetShippingCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetShippingCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetShippingCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetShippingCustomFieldActionQueryBuilderDsl>(p, OrderSetShippingCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetShippingCustomFieldActionQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<OrderSetShippingCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<OrderSetShippingCustomFieldActionQueryBuilderDsl>(p, OrderSetShippingCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetShippingCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<OrderSetShippingCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<OrderSetShippingCustomFieldActionQueryBuilderDsl>(p, OrderSetShippingCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetShippingCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<OrderSetShippingCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<OrderSetShippingCustomFieldActionQueryBuilderDsl>(p, OrderSetShippingCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
