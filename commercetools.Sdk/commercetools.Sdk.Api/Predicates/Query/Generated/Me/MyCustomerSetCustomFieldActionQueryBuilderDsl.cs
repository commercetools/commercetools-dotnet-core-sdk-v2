// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerSetCustomFieldActionQueryBuilderDsl
    {
        public MyCustomerSetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static MyCustomerSetCustomFieldActionQueryBuilderDsl Of()
        {
            return new MyCustomerSetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerSetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerSetCustomFieldActionQueryBuilderDsl>(p, MyCustomerSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerSetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<MyCustomerSetCustomFieldActionQueryBuilderDsl>(p, MyCustomerSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerSetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<MyCustomerSetCustomFieldActionQueryBuilderDsl>(p, MyCustomerSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
