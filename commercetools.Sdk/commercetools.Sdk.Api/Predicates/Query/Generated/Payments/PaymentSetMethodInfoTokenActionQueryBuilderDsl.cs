using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentSetMethodInfoTokenActionQueryBuilderDsl
    {
        public PaymentSetMethodInfoTokenActionQueryBuilderDsl()
        {
        }

        public static PaymentSetMethodInfoTokenActionQueryBuilderDsl Of()
        {
            return new PaymentSetMethodInfoTokenActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentSetMethodInfoTokenActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentSetMethodInfoTokenActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentSetMethodInfoTokenActionQueryBuilderDsl>(p, PaymentSetMethodInfoTokenActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentSetMethodInfoTokenActionQueryBuilderDsl> Token(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodTokenQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodTokenQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentSetMethodInfoTokenActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("token"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodTokenQueryBuilderDsl.Of())),
                PaymentSetMethodInfoTokenActionQueryBuilderDsl.Of);
        }


    }
}
