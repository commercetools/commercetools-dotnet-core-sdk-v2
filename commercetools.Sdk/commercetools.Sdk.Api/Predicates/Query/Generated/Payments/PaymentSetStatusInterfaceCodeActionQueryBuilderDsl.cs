// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentSetStatusInterfaceCodeActionQueryBuilderDsl
    {
        public PaymentSetStatusInterfaceCodeActionQueryBuilderDsl()
        {
        }

        public static PaymentSetStatusInterfaceCodeActionQueryBuilderDsl Of()
        {
            return new PaymentSetStatusInterfaceCodeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentSetStatusInterfaceCodeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentSetStatusInterfaceCodeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentSetStatusInterfaceCodeActionQueryBuilderDsl>(p, PaymentSetStatusInterfaceCodeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentSetStatusInterfaceCodeActionQueryBuilderDsl, string> InterfaceCode()
        {
            return new ComparisonPredicateBuilder<PaymentSetStatusInterfaceCodeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceCode")),
            p => new CombinationQueryPredicate<PaymentSetStatusInterfaceCodeActionQueryBuilderDsl>(p, PaymentSetStatusInterfaceCodeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
