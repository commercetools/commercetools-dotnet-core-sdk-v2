using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerSetDateOfBirthActionQueryBuilderDsl
    {
        public MyCustomerSetDateOfBirthActionQueryBuilderDsl()
        {
        }

        public static MyCustomerSetDateOfBirthActionQueryBuilderDsl Of()
        {
            return new MyCustomerSetDateOfBirthActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerSetDateOfBirthActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetDateOfBirthActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerSetDateOfBirthActionQueryBuilderDsl>(p, MyCustomerSetDateOfBirthActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerSetDateOfBirthActionQueryBuilderDsl, Date> DateOfBirth()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetDateOfBirthActionQueryBuilderDsl, Date>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("dateOfBirth")),
            p => new CombinationQueryPredicate<MyCustomerSetDateOfBirthActionQueryBuilderDsl>(p, MyCustomerSetDateOfBirthActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
