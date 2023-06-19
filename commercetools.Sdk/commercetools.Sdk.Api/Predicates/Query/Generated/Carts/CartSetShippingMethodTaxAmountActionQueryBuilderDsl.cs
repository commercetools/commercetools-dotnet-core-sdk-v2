using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetShippingMethodTaxAmountActionQueryBuilderDsl
    {
        public CartSetShippingMethodTaxAmountActionQueryBuilderDsl()
        {
        }

        public static CartSetShippingMethodTaxAmountActionQueryBuilderDsl Of()
        {
            return new CartSetShippingMethodTaxAmountActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetShippingMethodTaxAmountActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetShippingMethodTaxAmountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetShippingMethodTaxAmountActionQueryBuilderDsl>(p, CartSetShippingMethodTaxAmountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetShippingMethodTaxAmountActionQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<CartSetShippingMethodTaxAmountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<CartSetShippingMethodTaxAmountActionQueryBuilderDsl>(p, CartSetShippingMethodTaxAmountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetShippingMethodTaxAmountActionQueryBuilderDsl> ExternalTaxAmount(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxAmountDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxAmountDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetShippingMethodTaxAmountActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxAmount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxAmountDraftQueryBuilderDsl.Of())),
                CartSetShippingMethodTaxAmountActionQueryBuilderDsl.Of);
        }


    }
}
