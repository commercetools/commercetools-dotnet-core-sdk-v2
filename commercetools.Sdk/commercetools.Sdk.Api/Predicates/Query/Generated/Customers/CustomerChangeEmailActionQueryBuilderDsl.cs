// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerChangeEmailActionQueryBuilderDsl
    {
        public CustomerChangeEmailActionQueryBuilderDsl()
        {
        }

        public static CustomerChangeEmailActionQueryBuilderDsl Of()
        {
            return new CustomerChangeEmailActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerChangeEmailActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerChangeEmailActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerChangeEmailActionQueryBuilderDsl>(p, CustomerChangeEmailActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerChangeEmailActionQueryBuilderDsl, string> Email()
        {
            return new ComparisonPredicateBuilder<CustomerChangeEmailActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("email")),
            p => new CombinationQueryPredicate<CustomerChangeEmailActionQueryBuilderDsl>(p, CustomerChangeEmailActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
