// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentMethodPaymentMethodStatusSetMessagePayloadQueryBuilderDsl
    {
        public PaymentMethodPaymentMethodStatusSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentMethodPaymentMethodStatusSetMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentMethodPaymentMethodStatusSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodPaymentMethodStatusSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessagePayloadQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodPaymentMethodStatusSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessagePayloadQueryBuilderDsl, string> OldStatus()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldStatus")),
            p => new CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodPaymentMethodStatusSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
