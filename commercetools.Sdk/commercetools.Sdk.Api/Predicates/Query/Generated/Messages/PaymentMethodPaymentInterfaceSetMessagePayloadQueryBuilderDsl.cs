// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentMethodPaymentInterfaceSetMessagePayloadQueryBuilderDsl
    {
        public PaymentMethodPaymentInterfaceSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentMethodPaymentInterfaceSetMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentMethodPaymentInterfaceSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodPaymentInterfaceSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPaymentInterfaceSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentMethodPaymentInterfaceSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodPaymentInterfaceSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodPaymentInterfaceSetMessagePayloadQueryBuilderDsl, string> PaymentInterface()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPaymentInterfaceSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentInterface")),
            p => new CombinationQueryPredicate<PaymentMethodPaymentInterfaceSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodPaymentInterfaceSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodPaymentInterfaceSetMessagePayloadQueryBuilderDsl, string> OldPaymentInterface()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPaymentInterfaceSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldPaymentInterface")),
            p => new CombinationQueryPredicate<PaymentMethodPaymentInterfaceSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodPaymentInterfaceSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
