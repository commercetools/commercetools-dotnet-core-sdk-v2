using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyPaymentDraftQueryBuilderDsl
    {
        public MyPaymentDraftQueryBuilderDsl()
        {
        }

        public static MyPaymentDraftQueryBuilderDsl Of()
        {
            return new MyPaymentDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<MyPaymentDraftQueryBuilderDsl> AmountPlanned(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("amountPlanned"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                MyPaymentDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MyPaymentDraftQueryBuilderDsl> PaymentMethodInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentMethodInfoDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentMethodInfoDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentMethodInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentMethodInfoDraftQueryBuilderDsl.Of())),
                MyPaymentDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MyPaymentDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                MyPaymentDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MyPaymentDraftQueryBuilderDsl> Transaction(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyTransactionDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyTransactionDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("transaction"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyTransactionDraftQueryBuilderDsl.Of())),
                MyPaymentDraftQueryBuilderDsl.Of);
        }


    }
}
