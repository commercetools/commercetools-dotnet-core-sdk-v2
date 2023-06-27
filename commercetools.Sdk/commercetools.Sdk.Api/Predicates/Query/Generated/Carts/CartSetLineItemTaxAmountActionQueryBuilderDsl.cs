using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetLineItemTaxAmountActionQueryBuilderDsl
    {
        public CartSetLineItemTaxAmountActionQueryBuilderDsl()
        {
        }

        public static CartSetLineItemTaxAmountActionQueryBuilderDsl Of()
        {
            return new CartSetLineItemTaxAmountActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetLineItemTaxAmountActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemTaxAmountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetLineItemTaxAmountActionQueryBuilderDsl>(p, CartSetLineItemTaxAmountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetLineItemTaxAmountActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemTaxAmountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<CartSetLineItemTaxAmountActionQueryBuilderDsl>(p, CartSetLineItemTaxAmountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetLineItemTaxAmountActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemTaxAmountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<CartSetLineItemTaxAmountActionQueryBuilderDsl>(p, CartSetLineItemTaxAmountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetLineItemTaxAmountActionQueryBuilderDsl> ExternalTaxAmount(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxAmountDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxAmountDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetLineItemTaxAmountActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxAmount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxAmountDraftQueryBuilderDsl.Of())),
                CartSetLineItemTaxAmountActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartSetLineItemTaxAmountActionQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemTaxAmountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<CartSetLineItemTaxAmountActionQueryBuilderDsl>(p, CartSetLineItemTaxAmountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
