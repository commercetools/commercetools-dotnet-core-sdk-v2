// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl
    {
        public PaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl()
        {
        }

        public static PaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl Of()
        {
            return new PaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl>(p, PaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl, string> InterfaceAccount()
        {
            return new ComparisonPredicateBuilder<PaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceAccount")),
            p => new CombinationQueryPredicate<PaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl>(p, PaymentSetMethodInfoInterfaceAccountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
