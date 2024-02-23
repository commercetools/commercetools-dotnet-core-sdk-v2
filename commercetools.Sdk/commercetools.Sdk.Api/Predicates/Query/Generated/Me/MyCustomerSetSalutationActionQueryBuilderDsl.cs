// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerSetSalutationActionQueryBuilderDsl
    {
        public MyCustomerSetSalutationActionQueryBuilderDsl()
        {
        }

        public static MyCustomerSetSalutationActionQueryBuilderDsl Of()
        {
            return new MyCustomerSetSalutationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerSetSalutationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetSalutationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerSetSalutationActionQueryBuilderDsl>(p, MyCustomerSetSalutationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerSetSalutationActionQueryBuilderDsl, string> Salutation()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetSalutationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("salutation")),
            p => new CombinationQueryPredicate<MyCustomerSetSalutationActionQueryBuilderDsl>(p, MyCustomerSetSalutationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
