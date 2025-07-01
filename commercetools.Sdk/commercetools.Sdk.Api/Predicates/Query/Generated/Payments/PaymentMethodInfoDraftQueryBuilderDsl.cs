using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentMethodInfoDraftQueryBuilderDsl
    {
        public PaymentMethodInfoDraftQueryBuilderDsl()
        {
        }

        public static PaymentMethodInfoDraftQueryBuilderDsl Of()
        {
            return new PaymentMethodInfoDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodInfoDraftQueryBuilderDsl, string> PaymentInterface()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentInterface")),
            p => new CombinationQueryPredicate<PaymentMethodInfoDraftQueryBuilderDsl>(p, PaymentMethodInfoDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodInfoDraftQueryBuilderDsl, string> Method()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("method")),
            p => new CombinationQueryPredicate<PaymentMethodInfoDraftQueryBuilderDsl>(p, PaymentMethodInfoDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentMethodInfoDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodInfoDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                PaymentMethodInfoDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentMethodInfoDraftQueryBuilderDsl> Token(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodTokenQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodTokenQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodInfoDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("token"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodTokenQueryBuilderDsl.Of())),
                PaymentMethodInfoDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentMethodInfoDraftQueryBuilderDsl, string> InterfaceAccount()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceAccount")),
            p => new CombinationQueryPredicate<PaymentMethodInfoDraftQueryBuilderDsl>(p, PaymentMethodInfoDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentMethodInfoDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodInfoDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                PaymentMethodInfoDraftQueryBuilderDsl.Of);
        }


    }
}
