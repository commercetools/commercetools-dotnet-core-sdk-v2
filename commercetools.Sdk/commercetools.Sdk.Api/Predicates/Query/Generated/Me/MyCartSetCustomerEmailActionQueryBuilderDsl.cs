// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartSetCustomerEmailActionQueryBuilderDsl
    {
        public MyCartSetCustomerEmailActionQueryBuilderDsl()
        {
        }

        public static MyCartSetCustomerEmailActionQueryBuilderDsl Of()
        {
            return new MyCartSetCustomerEmailActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartSetCustomerEmailActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartSetCustomerEmailActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartSetCustomerEmailActionQueryBuilderDsl>(p, MyCartSetCustomerEmailActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartSetCustomerEmailActionQueryBuilderDsl, string> Email()
        {
            return new ComparisonPredicateBuilder<MyCartSetCustomerEmailActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("email")),
            p => new CombinationQueryPredicate<MyCartSetCustomerEmailActionQueryBuilderDsl>(p, MyCartSetCustomerEmailActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
