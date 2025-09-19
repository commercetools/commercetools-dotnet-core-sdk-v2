// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl
    {
        public PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl>(p, PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl, string> TransactionId()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transactionId")),
            p => new CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl>(p, PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl, string> NewInterfaceId()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newInterfaceId")),
            p => new CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl>(p, PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl, string> OldInterfaceId()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldInterfaceId")),
            p => new CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl>(p, PaymentTransactionInterfaceIdSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
