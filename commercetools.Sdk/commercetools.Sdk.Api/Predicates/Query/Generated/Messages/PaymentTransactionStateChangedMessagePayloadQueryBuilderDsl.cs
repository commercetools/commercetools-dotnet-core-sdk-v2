// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl
    {
        public PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl>(p, PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl, string> TransactionId()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transactionId")),
            p => new CombinationQueryPredicate<PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl>(p, PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl>(p, PaymentTransactionStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
