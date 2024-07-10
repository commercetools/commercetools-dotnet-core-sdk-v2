// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetCustomerIdActionQueryBuilderDsl
    {
        public OrderSetCustomerIdActionQueryBuilderDsl()
        {
        }

        public static OrderSetCustomerIdActionQueryBuilderDsl Of()
        {
            return new OrderSetCustomerIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetCustomerIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetCustomerIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetCustomerIdActionQueryBuilderDsl>(p, OrderSetCustomerIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetCustomerIdActionQueryBuilderDsl, string> CustomerId()
        {
            return new ComparisonPredicateBuilder<OrderSetCustomerIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerId")),
            p => new CombinationQueryPredicate<OrderSetCustomerIdActionQueryBuilderDsl>(p, OrderSetCustomerIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
