using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyPaymentUpdateActionQueryBuilderDsl
    {
        public MyPaymentUpdateActionQueryBuilderDsl()
        {
        }

        public static MyPaymentUpdateActionQueryBuilderDsl Of()
        {
            return new MyPaymentUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyPaymentUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyPaymentUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyPaymentUpdateActionQueryBuilderDsl>(p, MyPaymentUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<MyPaymentUpdateActionQueryBuilderDsl> AsAddTransaction(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentAddTransactionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentAddTransactionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentAddTransactionActionQueryBuilderDsl.Of()),
                MyPaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyPaymentUpdateActionQueryBuilderDsl> AsChangeAmountPlanned(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentChangeAmountPlannedActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentChangeAmountPlannedActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentChangeAmountPlannedActionQueryBuilderDsl.Of()),
                MyPaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyPaymentUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentSetCustomFieldActionQueryBuilderDsl.Of()),
                MyPaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyPaymentUpdateActionQueryBuilderDsl> AsSetMethodInfoInterface(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentSetMethodInfoInterfaceActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentSetMethodInfoInterfaceActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentSetMethodInfoInterfaceActionQueryBuilderDsl.Of()),
                MyPaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyPaymentUpdateActionQueryBuilderDsl> AsSetMethodInfoMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentSetMethodInfoMethodActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentSetMethodInfoMethodActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentSetMethodInfoMethodActionQueryBuilderDsl.Of()),
                MyPaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyPaymentUpdateActionQueryBuilderDsl> AsSetMethodInfoName(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentSetMethodInfoNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentSetMethodInfoNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentSetMethodInfoNameActionQueryBuilderDsl.Of()),
                MyPaymentUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyPaymentUpdateActionQueryBuilderDsl> AsSetTransactionCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl.Of()),
                MyPaymentUpdateActionQueryBuilderDsl.Of);
        }
    }
}
