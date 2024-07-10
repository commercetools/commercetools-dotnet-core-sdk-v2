// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class MyCustomerChangePasswordQueryBuilderDsl
    {
        public MyCustomerChangePasswordQueryBuilderDsl()
        {
        }

        public static MyCustomerChangePasswordQueryBuilderDsl Of()
        {
            return new MyCustomerChangePasswordQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerChangePasswordQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<MyCustomerChangePasswordQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<MyCustomerChangePasswordQueryBuilderDsl>(p, MyCustomerChangePasswordQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerChangePasswordQueryBuilderDsl, string> CurrentPassword()
        {
            return new ComparisonPredicateBuilder<MyCustomerChangePasswordQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currentPassword")),
            p => new CombinationQueryPredicate<MyCustomerChangePasswordQueryBuilderDsl>(p, MyCustomerChangePasswordQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerChangePasswordQueryBuilderDsl, string> NewPassword()
        {
            return new ComparisonPredicateBuilder<MyCustomerChangePasswordQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newPassword")),
            p => new CombinationQueryPredicate<MyCustomerChangePasswordQueryBuilderDsl>(p, MyCustomerChangePasswordQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
