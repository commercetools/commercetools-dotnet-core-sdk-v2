using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetDateOfBirthActionQueryBuilderDsl
    {
        public CustomerSetDateOfBirthActionQueryBuilderDsl()
        {
        }

        public static CustomerSetDateOfBirthActionQueryBuilderDsl Of()
        {
            return new CustomerSetDateOfBirthActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetDateOfBirthActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetDateOfBirthActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetDateOfBirthActionQueryBuilderDsl>(p, CustomerSetDateOfBirthActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetDateOfBirthActionQueryBuilderDsl, Date> DateOfBirth()
        {
            return new ComparisonPredicateBuilder<CustomerSetDateOfBirthActionQueryBuilderDsl, Date>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("dateOfBirth")),
            p => new CombinationQueryPredicate<CustomerSetDateOfBirthActionQueryBuilderDsl>(p, CustomerSetDateOfBirthActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
