// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyPaymentSetMethodInfoMethodActionQueryBuilderDsl
    {
        public MyPaymentSetMethodInfoMethodActionQueryBuilderDsl()
        {
        }

        public static MyPaymentSetMethodInfoMethodActionQueryBuilderDsl Of()
        {
            return new MyPaymentSetMethodInfoMethodActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyPaymentSetMethodInfoMethodActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyPaymentSetMethodInfoMethodActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyPaymentSetMethodInfoMethodActionQueryBuilderDsl>(p, MyPaymentSetMethodInfoMethodActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyPaymentSetMethodInfoMethodActionQueryBuilderDsl, string> Method()
        {
            return new ComparisonPredicateBuilder<MyPaymentSetMethodInfoMethodActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("method")),
            p => new CombinationQueryPredicate<MyPaymentSetMethodInfoMethodActionQueryBuilderDsl>(p, MyPaymentSetMethodInfoMethodActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
