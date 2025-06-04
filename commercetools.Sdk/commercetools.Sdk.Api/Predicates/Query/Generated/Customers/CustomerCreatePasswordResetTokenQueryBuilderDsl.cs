// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerCreatePasswordResetTokenQueryBuilderDsl
    {
        public CustomerCreatePasswordResetTokenQueryBuilderDsl()
        {
        }

        public static CustomerCreatePasswordResetTokenQueryBuilderDsl Of()
        {
            return new CustomerCreatePasswordResetTokenQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerCreatePasswordResetTokenQueryBuilderDsl, string> Email()
        {
            return new ComparisonPredicateBuilder<CustomerCreatePasswordResetTokenQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("email")),
            p => new CombinationQueryPredicate<CustomerCreatePasswordResetTokenQueryBuilderDsl>(p, CustomerCreatePasswordResetTokenQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCreatePasswordResetTokenQueryBuilderDsl, long> TtlMinutes()
        {
            return new ComparisonPredicateBuilder<CustomerCreatePasswordResetTokenQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("ttlMinutes")),
            p => new CombinationQueryPredicate<CustomerCreatePasswordResetTokenQueryBuilderDsl>(p, CustomerCreatePasswordResetTokenQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCreatePasswordResetTokenQueryBuilderDsl, bool> InvalidateOlderTokens()
        {
            return new ComparisonPredicateBuilder<CustomerCreatePasswordResetTokenQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("invalidateOlderTokens")),
            p => new CombinationQueryPredicate<CustomerCreatePasswordResetTokenQueryBuilderDsl>(p, CustomerCreatePasswordResetTokenQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
