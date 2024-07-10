using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentChangeTransactionStateActionQueryBuilderDsl
    {
        public PaymentChangeTransactionStateActionQueryBuilderDsl()
        {
        }

        public static PaymentChangeTransactionStateActionQueryBuilderDsl Of()
        {
            return new PaymentChangeTransactionStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentChangeTransactionStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentChangeTransactionStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentChangeTransactionStateActionQueryBuilderDsl>(p, PaymentChangeTransactionStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentChangeTransactionStateActionQueryBuilderDsl, string> TransactionId()
        {
            return new ComparisonPredicateBuilder<PaymentChangeTransactionStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transactionId")),
            p => new CombinationQueryPredicate<PaymentChangeTransactionStateActionQueryBuilderDsl>(p, PaymentChangeTransactionStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentChangeTransactionStateActionQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<PaymentChangeTransactionStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<PaymentChangeTransactionStateActionQueryBuilderDsl>(p, PaymentChangeTransactionStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
