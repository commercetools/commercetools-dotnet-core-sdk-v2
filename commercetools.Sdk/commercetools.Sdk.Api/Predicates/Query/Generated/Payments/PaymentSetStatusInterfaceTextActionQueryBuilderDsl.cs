// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentSetStatusInterfaceTextActionQueryBuilderDsl
    {
        public PaymentSetStatusInterfaceTextActionQueryBuilderDsl()
        {
        }

        public static PaymentSetStatusInterfaceTextActionQueryBuilderDsl Of()
        {
            return new PaymentSetStatusInterfaceTextActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentSetStatusInterfaceTextActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentSetStatusInterfaceTextActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentSetStatusInterfaceTextActionQueryBuilderDsl>(p, PaymentSetStatusInterfaceTextActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentSetStatusInterfaceTextActionQueryBuilderDsl, string> InterfaceText()
        {
            return new ComparisonPredicateBuilder<PaymentSetStatusInterfaceTextActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceText")),
            p => new CombinationQueryPredicate<PaymentSetStatusInterfaceTextActionQueryBuilderDsl>(p, PaymentSetStatusInterfaceTextActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
