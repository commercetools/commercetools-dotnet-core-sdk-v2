// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerEmailVerifyQueryBuilderDsl
    {
        public CustomerEmailVerifyQueryBuilderDsl()
        {
        }

        public static CustomerEmailVerifyQueryBuilderDsl Of()
        {
            return new CustomerEmailVerifyQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerEmailVerifyQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CustomerEmailVerifyQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CustomerEmailVerifyQueryBuilderDsl>(p, CustomerEmailVerifyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerEmailVerifyQueryBuilderDsl, string> TokenValue()
        {
            return new ComparisonPredicateBuilder<CustomerEmailVerifyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tokenValue")),
            p => new CombinationQueryPredicate<CustomerEmailVerifyQueryBuilderDsl>(p, CustomerEmailVerifyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
