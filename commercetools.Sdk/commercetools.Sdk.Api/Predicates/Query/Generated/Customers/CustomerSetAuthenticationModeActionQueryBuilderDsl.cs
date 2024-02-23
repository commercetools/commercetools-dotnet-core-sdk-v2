// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetAuthenticationModeActionQueryBuilderDsl
    {
        public CustomerSetAuthenticationModeActionQueryBuilderDsl()
        {
        }

        public static CustomerSetAuthenticationModeActionQueryBuilderDsl Of()
        {
            return new CustomerSetAuthenticationModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetAuthenticationModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetAuthenticationModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetAuthenticationModeActionQueryBuilderDsl>(p, CustomerSetAuthenticationModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetAuthenticationModeActionQueryBuilderDsl, string> AuthMode()
        {
            return new ComparisonPredicateBuilder<CustomerSetAuthenticationModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("authMode")),
            p => new CombinationQueryPredicate<CustomerSetAuthenticationModeActionQueryBuilderDsl>(p, CustomerSetAuthenticationModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetAuthenticationModeActionQueryBuilderDsl, string> Password()
        {
            return new ComparisonPredicateBuilder<CustomerSetAuthenticationModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("password")),
            p => new CombinationQueryPredicate<CustomerSetAuthenticationModeActionQueryBuilderDsl>(p, CustomerSetAuthenticationModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
