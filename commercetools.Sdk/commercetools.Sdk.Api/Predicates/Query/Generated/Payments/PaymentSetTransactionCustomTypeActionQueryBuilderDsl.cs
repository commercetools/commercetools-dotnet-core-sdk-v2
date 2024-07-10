using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentSetTransactionCustomTypeActionQueryBuilderDsl
    {
        public PaymentSetTransactionCustomTypeActionQueryBuilderDsl()
        {
        }

        public static PaymentSetTransactionCustomTypeActionQueryBuilderDsl Of()
        {
            return new PaymentSetTransactionCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentSetTransactionCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentSetTransactionCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentSetTransactionCustomTypeActionQueryBuilderDsl>(p, PaymentSetTransactionCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentSetTransactionCustomTypeActionQueryBuilderDsl, string> TransactionId()
        {
            return new ComparisonPredicateBuilder<PaymentSetTransactionCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transactionId")),
            p => new CombinationQueryPredicate<PaymentSetTransactionCustomTypeActionQueryBuilderDsl>(p, PaymentSetTransactionCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentSetTransactionCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentSetTransactionCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                PaymentSetTransactionCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentSetTransactionCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentSetTransactionCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                PaymentSetTransactionCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
