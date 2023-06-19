using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentTransactionAddedMessagePayloadQueryBuilderDsl
    {
        public PaymentTransactionAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentTransactionAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentTransactionAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentTransactionAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentTransactionAddedMessagePayloadQueryBuilderDsl>(p, PaymentTransactionAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentTransactionAddedMessagePayloadQueryBuilderDsl> Transaction(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.TransactionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.TransactionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentTransactionAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("transaction"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.TransactionQueryBuilderDsl.Of())),
                PaymentTransactionAddedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
