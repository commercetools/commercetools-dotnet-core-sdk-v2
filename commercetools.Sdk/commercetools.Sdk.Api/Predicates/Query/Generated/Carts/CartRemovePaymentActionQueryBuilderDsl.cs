using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartRemovePaymentActionQueryBuilderDsl
    {
        public CartRemovePaymentActionQueryBuilderDsl()
        {
        }

        public static CartRemovePaymentActionQueryBuilderDsl Of()
        {
            return new CartRemovePaymentActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartRemovePaymentActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartRemovePaymentActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartRemovePaymentActionQueryBuilderDsl>(p, CartRemovePaymentActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartRemovePaymentActionQueryBuilderDsl> Payment(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartRemovePaymentActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("payment"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl.Of())),
                CartRemovePaymentActionQueryBuilderDsl.Of);
        }


    }
}
