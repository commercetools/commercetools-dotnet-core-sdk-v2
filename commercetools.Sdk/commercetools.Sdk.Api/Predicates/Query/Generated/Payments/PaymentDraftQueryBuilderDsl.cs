using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentDraftQueryBuilderDsl
    {
        public PaymentDraftQueryBuilderDsl()
        {
        }

        public static PaymentDraftQueryBuilderDsl Of()
        {
            return new PaymentDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<PaymentDraftQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl.Of())),
                PaymentDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentDraftQueryBuilderDsl, string> AnonymousId()
        {
            return new ComparisonPredicateBuilder<PaymentDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousId")),
            p => new CombinationQueryPredicate<PaymentDraftQueryBuilderDsl>(p, PaymentDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentDraftQueryBuilderDsl, string> InterfaceId()
        {
            return new ComparisonPredicateBuilder<PaymentDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceId")),
            p => new CombinationQueryPredicate<PaymentDraftQueryBuilderDsl>(p, PaymentDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentDraftQueryBuilderDsl> AmountPlanned(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("amountPlanned"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                PaymentDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentDraftQueryBuilderDsl> PaymentMethodInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentMethodInfoDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentMethodInfoDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentMethodInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentMethodInfoDraftQueryBuilderDsl.Of())),
                PaymentDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentDraftQueryBuilderDsl> PaymentStatus(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentStatusDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentStatusDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentStatus"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentStatusDraftQueryBuilderDsl.Of())),
                PaymentDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentDraftQueryBuilderDsl> Transactions(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.TransactionDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.TransactionDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("transactions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.TransactionDraftQueryBuilderDsl.Of())),
                PaymentDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<PaymentDraftQueryBuilderDsl> Transactions()
        {
            return new CollectionPredicateBuilder<PaymentDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transactions")),
                    p => new CombinationQueryPredicate<PaymentDraftQueryBuilderDsl>(p, PaymentDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<PaymentDraftQueryBuilderDsl> InterfaceInteractions(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("interfaceInteractions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                PaymentDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<PaymentDraftQueryBuilderDsl> InterfaceInteractions()
        {
            return new CollectionPredicateBuilder<PaymentDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceInteractions")),
                    p => new CombinationQueryPredicate<PaymentDraftQueryBuilderDsl>(p, PaymentDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<PaymentDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                PaymentDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<PaymentDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<PaymentDraftQueryBuilderDsl>(p, PaymentDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
