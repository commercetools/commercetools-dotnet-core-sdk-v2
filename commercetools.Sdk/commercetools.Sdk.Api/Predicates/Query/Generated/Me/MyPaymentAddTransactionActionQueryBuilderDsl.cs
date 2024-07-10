using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyPaymentAddTransactionActionQueryBuilderDsl
    {
        public MyPaymentAddTransactionActionQueryBuilderDsl()
        {
        }

        public static MyPaymentAddTransactionActionQueryBuilderDsl Of()
        {
            return new MyPaymentAddTransactionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyPaymentAddTransactionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyPaymentAddTransactionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyPaymentAddTransactionActionQueryBuilderDsl>(p, MyPaymentAddTransactionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyPaymentAddTransactionActionQueryBuilderDsl> Transaction(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.TransactionDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.TransactionDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentAddTransactionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("transaction"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.TransactionDraftQueryBuilderDsl.Of())),
                MyPaymentAddTransactionActionQueryBuilderDsl.Of);
        }


    }
}
