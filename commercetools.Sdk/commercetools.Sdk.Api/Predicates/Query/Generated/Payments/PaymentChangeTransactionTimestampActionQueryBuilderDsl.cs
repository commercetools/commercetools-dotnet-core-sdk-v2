using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentChangeTransactionTimestampActionQueryBuilderDsl
    {
        public PaymentChangeTransactionTimestampActionQueryBuilderDsl()
        {
        }

        public static PaymentChangeTransactionTimestampActionQueryBuilderDsl Of()
        {
            return new PaymentChangeTransactionTimestampActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentChangeTransactionTimestampActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentChangeTransactionTimestampActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentChangeTransactionTimestampActionQueryBuilderDsl>(p, PaymentChangeTransactionTimestampActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentChangeTransactionTimestampActionQueryBuilderDsl, string> TransactionId()
        {
            return new ComparisonPredicateBuilder<PaymentChangeTransactionTimestampActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transactionId")),
            p => new CombinationQueryPredicate<PaymentChangeTransactionTimestampActionQueryBuilderDsl>(p, PaymentChangeTransactionTimestampActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentChangeTransactionTimestampActionQueryBuilderDsl, DateTime> Timestamp()
        {
            return new ComparisonPredicateBuilder<PaymentChangeTransactionTimestampActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("timestamp")),
            p => new CombinationQueryPredicate<PaymentChangeTransactionTimestampActionQueryBuilderDsl>(p, PaymentChangeTransactionTimestampActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
