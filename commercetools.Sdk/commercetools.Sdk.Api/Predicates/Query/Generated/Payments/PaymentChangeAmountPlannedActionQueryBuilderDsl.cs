using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentChangeAmountPlannedActionQueryBuilderDsl
    {
        public PaymentChangeAmountPlannedActionQueryBuilderDsl()
        {
        }

        public static PaymentChangeAmountPlannedActionQueryBuilderDsl Of()
        {
            return new PaymentChangeAmountPlannedActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentChangeAmountPlannedActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentChangeAmountPlannedActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentChangeAmountPlannedActionQueryBuilderDsl>(p, PaymentChangeAmountPlannedActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentChangeAmountPlannedActionQueryBuilderDsl> Amount(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentChangeAmountPlannedActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("amount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                PaymentChangeAmountPlannedActionQueryBuilderDsl.Of);
        }


    }
}
