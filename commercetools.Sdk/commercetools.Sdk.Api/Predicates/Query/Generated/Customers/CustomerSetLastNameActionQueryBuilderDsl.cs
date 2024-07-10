// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetLastNameActionQueryBuilderDsl
    {
        public CustomerSetLastNameActionQueryBuilderDsl()
        {
        }

        public static CustomerSetLastNameActionQueryBuilderDsl Of()
        {
            return new CustomerSetLastNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetLastNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetLastNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetLastNameActionQueryBuilderDsl>(p, CustomerSetLastNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetLastNameActionQueryBuilderDsl, string> LastName()
        {
            return new ComparisonPredicateBuilder<CustomerSetLastNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastName")),
            p => new CombinationQueryPredicate<CustomerSetLastNameActionQueryBuilderDsl>(p, CustomerSetLastNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
