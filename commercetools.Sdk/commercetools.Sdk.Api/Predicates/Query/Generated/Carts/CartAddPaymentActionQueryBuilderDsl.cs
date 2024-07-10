using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartAddPaymentActionQueryBuilderDsl
    {
        public CartAddPaymentActionQueryBuilderDsl()
        {
        }

        public static CartAddPaymentActionQueryBuilderDsl Of()
        {
            return new CartAddPaymentActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartAddPaymentActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartAddPaymentActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartAddPaymentActionQueryBuilderDsl>(p, CartAddPaymentActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartAddPaymentActionQueryBuilderDsl> Payment(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartAddPaymentActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("payment"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl.Of())),
                CartAddPaymentActionQueryBuilderDsl.Of);
        }


    }
}
