// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyPaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl
    {
        public MyPaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl()
        {
        }

        public static MyPaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl Of()
        {
            return new MyPaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyPaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyPaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyPaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl>(p, MyPaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyPaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl, string> InterfaceAccount()
        {
            return new ComparisonPredicateBuilder<MyPaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceAccount")),
            p => new CombinationQueryPredicate<MyPaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl>(p, MyPaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
