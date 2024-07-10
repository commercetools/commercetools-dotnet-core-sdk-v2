// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerSetTitleActionQueryBuilderDsl
    {
        public MyCustomerSetTitleActionQueryBuilderDsl()
        {
        }

        public static MyCustomerSetTitleActionQueryBuilderDsl Of()
        {
            return new MyCustomerSetTitleActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerSetTitleActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetTitleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerSetTitleActionQueryBuilderDsl>(p, MyCustomerSetTitleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerSetTitleActionQueryBuilderDsl, string> Title()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetTitleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("title")),
            p => new CombinationQueryPredicate<MyCustomerSetTitleActionQueryBuilderDsl>(p, MyCustomerSetTitleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
