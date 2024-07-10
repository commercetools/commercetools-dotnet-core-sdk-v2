using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentAddTransactionActionQueryBuilderDsl
    {
        public PaymentAddTransactionActionQueryBuilderDsl()
        {
        }

        public static PaymentAddTransactionActionQueryBuilderDsl Of()
        {
            return new PaymentAddTransactionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentAddTransactionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentAddTransactionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentAddTransactionActionQueryBuilderDsl>(p, PaymentAddTransactionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentAddTransactionActionQueryBuilderDsl> Transaction(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.TransactionDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.TransactionDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentAddTransactionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("transaction"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.TransactionDraftQueryBuilderDsl.Of())),
                PaymentAddTransactionActionQueryBuilderDsl.Of);
        }


    }
}
