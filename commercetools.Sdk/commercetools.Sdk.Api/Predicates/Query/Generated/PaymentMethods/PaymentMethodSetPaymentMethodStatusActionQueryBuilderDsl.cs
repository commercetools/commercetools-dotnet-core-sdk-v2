// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.PaymentMethods
{

    public partial class PaymentMethodSetPaymentMethodStatusActionQueryBuilderDsl
    {
        public PaymentMethodSetPaymentMethodStatusActionQueryBuilderDsl()
        {
        }

        public static PaymentMethodSetPaymentMethodStatusActionQueryBuilderDsl Of()
        {
            return new PaymentMethodSetPaymentMethodStatusActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodSetPaymentMethodStatusActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentMethodSetPaymentMethodStatusActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentMethodSetPaymentMethodStatusActionQueryBuilderDsl>(p, PaymentMethodSetPaymentMethodStatusActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodSetPaymentMethodStatusActionQueryBuilderDsl, string> PaymentMethodStatus()
        {
            return new ComparisonPredicateBuilder<PaymentMethodSetPaymentMethodStatusActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentMethodStatus")),
            p => new CombinationQueryPredicate<PaymentMethodSetPaymentMethodStatusActionQueryBuilderDsl>(p, PaymentMethodSetPaymentMethodStatusActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
