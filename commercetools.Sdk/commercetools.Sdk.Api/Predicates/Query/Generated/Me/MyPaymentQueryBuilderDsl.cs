using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyPaymentQueryBuilderDsl
    {
        public MyPaymentQueryBuilderDsl()
        {
        }

        public static MyPaymentQueryBuilderDsl Of()
        {
            return new MyPaymentQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyPaymentQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<MyPaymentQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<MyPaymentQueryBuilderDsl>(p, MyPaymentQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyPaymentQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<MyPaymentQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<MyPaymentQueryBuilderDsl>(p, MyPaymentQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyPaymentQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                MyPaymentQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<MyPaymentQueryBuilderDsl, string> AnonymousId()
        {
            return new ComparisonPredicateBuilder<MyPaymentQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousId")),
            p => new CombinationQueryPredicate<MyPaymentQueryBuilderDsl>(p, MyPaymentQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyPaymentQueryBuilderDsl> AmountPlanned(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("amountPlanned"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                MyPaymentQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MyPaymentQueryBuilderDsl> PaymentMethodInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentMethodInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentMethodInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentMethodInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentMethodInfoQueryBuilderDsl.Of())),
                MyPaymentQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MyPaymentQueryBuilderDsl> Transactions(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.TransactionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.TransactionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("transactions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.TransactionQueryBuilderDsl.Of())),
                MyPaymentQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyPaymentQueryBuilderDsl> Transactions()
        {
            return new CollectionPredicateBuilder<MyPaymentQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transactions")),
                    p => new CombinationQueryPredicate<MyPaymentQueryBuilderDsl>(p, MyPaymentQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<MyPaymentQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                MyPaymentQueryBuilderDsl.Of);
        }


    }
}
