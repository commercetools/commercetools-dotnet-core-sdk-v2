using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentSetMethodInfoNameActionQueryBuilderDsl
    {
        public PaymentSetMethodInfoNameActionQueryBuilderDsl()
        {
        }

        public static PaymentSetMethodInfoNameActionQueryBuilderDsl Of()
        {
            return new PaymentSetMethodInfoNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentSetMethodInfoNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentSetMethodInfoNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentSetMethodInfoNameActionQueryBuilderDsl>(p, PaymentSetMethodInfoNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentSetMethodInfoNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentSetMethodInfoNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                PaymentSetMethodInfoNameActionQueryBuilderDsl.Of);
        }


    }
}
