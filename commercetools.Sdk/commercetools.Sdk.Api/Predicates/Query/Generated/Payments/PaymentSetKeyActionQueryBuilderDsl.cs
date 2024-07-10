using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentSetKeyActionQueryBuilderDsl
    {
        public PaymentSetKeyActionQueryBuilderDsl()
        {
        }

        public static PaymentSetKeyActionQueryBuilderDsl Of()
        {
            return new PaymentSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentSetKeyActionQueryBuilderDsl>(p, PaymentSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<PaymentSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<PaymentSetKeyActionQueryBuilderDsl>(p, PaymentSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
