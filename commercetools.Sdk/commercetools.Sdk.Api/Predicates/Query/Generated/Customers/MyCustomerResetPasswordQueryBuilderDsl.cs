// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class MyCustomerResetPasswordQueryBuilderDsl
    {
        public MyCustomerResetPasswordQueryBuilderDsl()
        {
        }

        public static MyCustomerResetPasswordQueryBuilderDsl Of()
        {
            return new MyCustomerResetPasswordQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerResetPasswordQueryBuilderDsl, string> TokenValue()
        {
            return new ComparisonPredicateBuilder<MyCustomerResetPasswordQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tokenValue")),
            p => new CombinationQueryPredicate<MyCustomerResetPasswordQueryBuilderDsl>(p, MyCustomerResetPasswordQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerResetPasswordQueryBuilderDsl, string> NewPassword()
        {
            return new ComparisonPredicateBuilder<MyCustomerResetPasswordQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newPassword")),
            p => new CombinationQueryPredicate<MyCustomerResetPasswordQueryBuilderDsl>(p, MyCustomerResetPasswordQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
