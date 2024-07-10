using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentQueryBuilderDsl
    {
        public PaymentQueryBuilderDsl()
        {
        }

        public static PaymentQueryBuilderDsl Of()
        {
            return new PaymentQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<PaymentQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<PaymentQueryBuilderDsl>(p, PaymentQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<PaymentQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<PaymentQueryBuilderDsl>(p, PaymentQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<PaymentQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<PaymentQueryBuilderDsl>(p, PaymentQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<PaymentQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<PaymentQueryBuilderDsl>(p, PaymentQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                PaymentQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                PaymentQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                PaymentQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentQueryBuilderDsl, string> AnonymousId()
        {
            return new ComparisonPredicateBuilder<PaymentQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousId")),
            p => new CombinationQueryPredicate<PaymentQueryBuilderDsl>(p, PaymentQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentQueryBuilderDsl, string> InterfaceId()
        {
            return new ComparisonPredicateBuilder<PaymentQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceId")),
            p => new CombinationQueryPredicate<PaymentQueryBuilderDsl>(p, PaymentQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentQueryBuilderDsl> AmountPlanned(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("amountPlanned"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                PaymentQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentQueryBuilderDsl> PaymentMethodInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentMethodInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentMethodInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentMethodInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentMethodInfoQueryBuilderDsl.Of())),
                PaymentQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentQueryBuilderDsl> PaymentStatus(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentStatusQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentStatusQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentStatus"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentStatusQueryBuilderDsl.Of())),
                PaymentQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentQueryBuilderDsl> Transactions(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.TransactionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.TransactionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("transactions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.TransactionQueryBuilderDsl.Of())),
                PaymentQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<PaymentQueryBuilderDsl> Transactions()
        {
            return new CollectionPredicateBuilder<PaymentQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transactions")),
                    p => new CombinationQueryPredicate<PaymentQueryBuilderDsl>(p, PaymentQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<PaymentQueryBuilderDsl> InterfaceInteractions(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("interfaceInteractions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                PaymentQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<PaymentQueryBuilderDsl> InterfaceInteractions()
        {
            return new CollectionPredicateBuilder<PaymentQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceInteractions")),
                    p => new CombinationQueryPredicate<PaymentQueryBuilderDsl>(p, PaymentQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<PaymentQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                PaymentQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<PaymentQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<PaymentQueryBuilderDsl>(p, PaymentQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
