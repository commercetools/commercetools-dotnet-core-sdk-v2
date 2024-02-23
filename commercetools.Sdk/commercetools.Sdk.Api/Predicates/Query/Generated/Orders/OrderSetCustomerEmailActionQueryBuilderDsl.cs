// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetCustomerEmailActionQueryBuilderDsl
    {
        public OrderSetCustomerEmailActionQueryBuilderDsl()
        {
        }

        public static OrderSetCustomerEmailActionQueryBuilderDsl Of()
        {
            return new OrderSetCustomerEmailActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetCustomerEmailActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetCustomerEmailActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetCustomerEmailActionQueryBuilderDsl>(p, OrderSetCustomerEmailActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetCustomerEmailActionQueryBuilderDsl, string> Email()
        {
            return new ComparisonPredicateBuilder<OrderSetCustomerEmailActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("email")),
            p => new CombinationQueryPredicate<OrderSetCustomerEmailActionQueryBuilderDsl>(p, OrderSetCustomerEmailActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
