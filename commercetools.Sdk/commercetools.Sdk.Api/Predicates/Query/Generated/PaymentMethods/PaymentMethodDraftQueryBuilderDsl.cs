using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.PaymentMethods
{

    public partial class PaymentMethodDraftQueryBuilderDsl
    {
        public PaymentMethodDraftQueryBuilderDsl()
        {
        }

        public static PaymentMethodDraftQueryBuilderDsl Of()
        {
            return new PaymentMethodDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<PaymentMethodDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<PaymentMethodDraftQueryBuilderDsl>(p, PaymentMethodDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentMethodDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                PaymentMethodDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentMethodDraftQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl.Of())),
                PaymentMethodDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentMethodDraftQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl.Of())),
                PaymentMethodDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentMethodDraftQueryBuilderDsl, string> Method()
        {
            return new ComparisonPredicateBuilder<PaymentMethodDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("method")),
            p => new CombinationQueryPredicate<PaymentMethodDraftQueryBuilderDsl>(p, PaymentMethodDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodDraftQueryBuilderDsl, string> PaymentInterface()
        {
            return new ComparisonPredicateBuilder<PaymentMethodDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentInterface")),
            p => new CombinationQueryPredicate<PaymentMethodDraftQueryBuilderDsl>(p, PaymentMethodDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodDraftQueryBuilderDsl, string> InterfaceAccount()
        {
            return new ComparisonPredicateBuilder<PaymentMethodDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceAccount")),
            p => new CombinationQueryPredicate<PaymentMethodDraftQueryBuilderDsl>(p, PaymentMethodDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentMethodDraftQueryBuilderDsl> Token(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodTokenQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodTokenQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("token"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodTokenQueryBuilderDsl.Of())),
                PaymentMethodDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentMethodDraftQueryBuilderDsl, string> PaymentMethodStatus()
        {
            return new ComparisonPredicateBuilder<PaymentMethodDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentMethodStatus")),
            p => new CombinationQueryPredicate<PaymentMethodDraftQueryBuilderDsl>(p, PaymentMethodDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodDraftQueryBuilderDsl, bool> Default()
        {
            return new ComparisonPredicateBuilder<PaymentMethodDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("default")),
            p => new CombinationQueryPredicate<PaymentMethodDraftQueryBuilderDsl>(p, PaymentMethodDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentMethodDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                PaymentMethodDraftQueryBuilderDsl.Of);
        }


    }
}
