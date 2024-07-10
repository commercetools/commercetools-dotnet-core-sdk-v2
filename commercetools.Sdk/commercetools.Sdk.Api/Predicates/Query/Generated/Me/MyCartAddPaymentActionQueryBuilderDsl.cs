using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartAddPaymentActionQueryBuilderDsl
    {
        public MyCartAddPaymentActionQueryBuilderDsl()
        {
        }

        public static MyCartAddPaymentActionQueryBuilderDsl Of()
        {
            return new MyCartAddPaymentActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartAddPaymentActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartAddPaymentActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartAddPaymentActionQueryBuilderDsl>(p, MyCartAddPaymentActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCartAddPaymentActionQueryBuilderDsl> Payment(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartAddPaymentActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("payment"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl.Of())),
                MyCartAddPaymentActionQueryBuilderDsl.Of);
        }


    }
}
