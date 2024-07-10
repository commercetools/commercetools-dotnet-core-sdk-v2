using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyPaymentChangeAmountPlannedActionQueryBuilderDsl
    {
        public MyPaymentChangeAmountPlannedActionQueryBuilderDsl()
        {
        }

        public static MyPaymentChangeAmountPlannedActionQueryBuilderDsl Of()
        {
            return new MyPaymentChangeAmountPlannedActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyPaymentChangeAmountPlannedActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyPaymentChangeAmountPlannedActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyPaymentChangeAmountPlannedActionQueryBuilderDsl>(p, MyPaymentChangeAmountPlannedActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyPaymentChangeAmountPlannedActionQueryBuilderDsl> Amount(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentChangeAmountPlannedActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("amount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                MyPaymentChangeAmountPlannedActionQueryBuilderDsl.Of);
        }


    }
}
