// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetBillingAddressCustomFieldActionQueryBuilderDsl
    {
        public OrderSetBillingAddressCustomFieldActionQueryBuilderDsl()
        {
        }

        public static OrderSetBillingAddressCustomFieldActionQueryBuilderDsl Of()
        {
            return new OrderSetBillingAddressCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetBillingAddressCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetBillingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetBillingAddressCustomFieldActionQueryBuilderDsl>(p, OrderSetBillingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetBillingAddressCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<OrderSetBillingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<OrderSetBillingAddressCustomFieldActionQueryBuilderDsl>(p, OrderSetBillingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetBillingAddressCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<OrderSetBillingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<OrderSetBillingAddressCustomFieldActionQueryBuilderDsl>(p, OrderSetBillingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
