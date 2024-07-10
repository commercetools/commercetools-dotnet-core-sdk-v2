// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerSetCompanyNameActionQueryBuilderDsl
    {
        public MyCustomerSetCompanyNameActionQueryBuilderDsl()
        {
        }

        public static MyCustomerSetCompanyNameActionQueryBuilderDsl Of()
        {
            return new MyCustomerSetCompanyNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerSetCompanyNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetCompanyNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerSetCompanyNameActionQueryBuilderDsl>(p, MyCustomerSetCompanyNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerSetCompanyNameActionQueryBuilderDsl, string> CompanyName()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetCompanyNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("companyName")),
            p => new CombinationQueryPredicate<MyCustomerSetCompanyNameActionQueryBuilderDsl>(p, MyCustomerSetCompanyNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
