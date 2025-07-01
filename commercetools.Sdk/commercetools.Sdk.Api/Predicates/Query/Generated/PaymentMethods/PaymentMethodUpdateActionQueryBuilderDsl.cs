using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.PaymentMethods
{

    public partial class PaymentMethodUpdateActionQueryBuilderDsl
    {
        public PaymentMethodUpdateActionQueryBuilderDsl()
        {
        }

        public static PaymentMethodUpdateActionQueryBuilderDsl Of()
        {
            return new PaymentMethodUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentMethodUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl>(p, PaymentMethodUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetCustomFieldActionQueryBuilderDsl.Of()),
                PaymentMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetCustomTypeActionQueryBuilderDsl.Of()),
                PaymentMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl> AsSetDefault(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetDefaultActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetDefaultActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetDefaultActionQueryBuilderDsl.Of()),
                PaymentMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl> AsSetInterfaceAccount(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetInterfaceAccountActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetInterfaceAccountActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetInterfaceAccountActionQueryBuilderDsl.Of()),
                PaymentMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetKeyActionQueryBuilderDsl.Of()),
                PaymentMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl> AsSetMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetMethodActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetMethodActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetMethodActionQueryBuilderDsl.Of()),
                PaymentMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl> AsSetName(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetNameActionQueryBuilderDsl.Of()),
                PaymentMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl> AsSetPaymentInterface(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetPaymentInterfaceActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetPaymentInterfaceActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetPaymentInterfaceActionQueryBuilderDsl.Of()),
                PaymentMethodUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl> AsSetPaymentMethodStatus(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetPaymentMethodStatusActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetPaymentMethodStatusActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodSetPaymentMethodStatusActionQueryBuilderDsl.Of()),
                PaymentMethodUpdateActionQueryBuilderDsl.Of);
        }
    }
}
