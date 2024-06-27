// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class CustomerSearchProjectNotIndexedErrorQueryBuilderDsl
    {
        public CustomerSearchProjectNotIndexedErrorQueryBuilderDsl()
        {
        }

        public static CustomerSearchProjectNotIndexedErrorQueryBuilderDsl Of()
        {
            return new CustomerSearchProjectNotIndexedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSearchProjectNotIndexedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<CustomerSearchProjectNotIndexedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<CustomerSearchProjectNotIndexedErrorQueryBuilderDsl>(p, CustomerSearchProjectNotIndexedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSearchProjectNotIndexedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<CustomerSearchProjectNotIndexedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<CustomerSearchProjectNotIndexedErrorQueryBuilderDsl>(p, CustomerSearchProjectNotIndexedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
