using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentUpdateActionQueryBuilderDsl
    {
        public PaymentUpdateActionQueryBuilderDsl()
        {
        }

        public static PaymentUpdateActionQueryBuilderDsl Of()
        {
            return new PaymentUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(p, PaymentUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsAddInterfaceInteraction(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentAddInterfaceInteractionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentAddInterfaceInteractionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentAddInterfaceInteractionActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsAddTransaction(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentAddTransactionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentAddTransactionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentAddTransactionActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsChangeAmountPlanned(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentChangeAmountPlannedActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentChangeAmountPlannedActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentChangeAmountPlannedActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsChangeTransactionInteractionId(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentChangeTransactionInteractionIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentChangeTransactionInteractionIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentChangeTransactionInteractionIdActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsChangeTransactionState(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentChangeTransactionStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentChangeTransactionStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentChangeTransactionStateActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsChangeTransactionTimestamp(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentChangeTransactionTimestampActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentChangeTransactionTimestampActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentChangeTransactionTimestampActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsSetAnonymousId(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetAnonymousIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetAnonymousIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetAnonymousIdActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetCustomFieldActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetCustomTypeActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsSetCustomer(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetCustomerActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetCustomerActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetCustomerActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsSetInterfaceId(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetInterfaceIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetInterfaceIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetInterfaceIdActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetKeyActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsSetMethodInfoInterface(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetMethodInfoInterfaceActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetMethodInfoInterfaceActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetMethodInfoInterfaceActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsSetMethodInfoMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetMethodInfoMethodActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetMethodInfoMethodActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetMethodInfoMethodActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsSetMethodInfoName(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetMethodInfoNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetMethodInfoNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetMethodInfoNameActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsSetStatusInterfaceCode(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetStatusInterfaceCodeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetStatusInterfaceCodeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetStatusInterfaceCodeActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsSetStatusInterfaceText(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetStatusInterfaceTextActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetStatusInterfaceTextActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetStatusInterfaceTextActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsSetTransactionCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetTransactionCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetTransactionCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetTransactionCustomFieldActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsSetTransactionCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetTransactionCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetTransactionCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentSetTransactionCustomTypeActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl> AsTransitionState(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentTransitionStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentTransitionStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentTransitionStateActionQueryBuilderDsl.Of()),
                PaymentUpdateActionQueryBuilderDsl.Of);
        }
    }
}
