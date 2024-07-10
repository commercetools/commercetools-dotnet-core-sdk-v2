using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentChangeTransactionInteractionIdActionQueryBuilderDsl
    {
        public PaymentChangeTransactionInteractionIdActionQueryBuilderDsl()
        {
        }

        public static PaymentChangeTransactionInteractionIdActionQueryBuilderDsl Of()
        {
            return new PaymentChangeTransactionInteractionIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentChangeTransactionInteractionIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentChangeTransactionInteractionIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentChangeTransactionInteractionIdActionQueryBuilderDsl>(p, PaymentChangeTransactionInteractionIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentChangeTransactionInteractionIdActionQueryBuilderDsl, string> TransactionId()
        {
            return new ComparisonPredicateBuilder<PaymentChangeTransactionInteractionIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transactionId")),
            p => new CombinationQueryPredicate<PaymentChangeTransactionInteractionIdActionQueryBuilderDsl>(p, PaymentChangeTransactionInteractionIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentChangeTransactionInteractionIdActionQueryBuilderDsl, string> InteractionId()
        {
            return new ComparisonPredicateBuilder<PaymentChangeTransactionInteractionIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interactionId")),
            p => new CombinationQueryPredicate<PaymentChangeTransactionInteractionIdActionQueryBuilderDsl>(p, PaymentChangeTransactionInteractionIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
