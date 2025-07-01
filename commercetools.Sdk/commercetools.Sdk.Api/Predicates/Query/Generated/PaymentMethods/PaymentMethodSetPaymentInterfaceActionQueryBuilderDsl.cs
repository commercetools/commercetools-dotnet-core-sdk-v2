// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.PaymentMethods
{

    public partial class PaymentMethodSetPaymentInterfaceActionQueryBuilderDsl
    {
        public PaymentMethodSetPaymentInterfaceActionQueryBuilderDsl()
        {
        }

        public static PaymentMethodSetPaymentInterfaceActionQueryBuilderDsl Of()
        {
            return new PaymentMethodSetPaymentInterfaceActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodSetPaymentInterfaceActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentMethodSetPaymentInterfaceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentMethodSetPaymentInterfaceActionQueryBuilderDsl>(p, PaymentMethodSetPaymentInterfaceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodSetPaymentInterfaceActionQueryBuilderDsl, string> PaymentInterface()
        {
            return new ComparisonPredicateBuilder<PaymentMethodSetPaymentInterfaceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentInterface")),
            p => new CombinationQueryPredicate<PaymentMethodSetPaymentInterfaceActionQueryBuilderDsl>(p, PaymentMethodSetPaymentInterfaceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
