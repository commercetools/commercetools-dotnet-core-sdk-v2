using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetCustomLineItemTaxAmountActionQueryBuilderDsl
    {
        public CartSetCustomLineItemTaxAmountActionQueryBuilderDsl()
        {
        }

        public static CartSetCustomLineItemTaxAmountActionQueryBuilderDsl Of()
        {
            return new CartSetCustomLineItemTaxAmountActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetCustomLineItemTaxAmountActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetCustomLineItemTaxAmountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetCustomLineItemTaxAmountActionQueryBuilderDsl>(p, CartSetCustomLineItemTaxAmountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetCustomLineItemTaxAmountActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<CartSetCustomLineItemTaxAmountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<CartSetCustomLineItemTaxAmountActionQueryBuilderDsl>(p, CartSetCustomLineItemTaxAmountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetCustomLineItemTaxAmountActionQueryBuilderDsl, string> CustomLineItemKey()
        {
            return new ComparisonPredicateBuilder<CartSetCustomLineItemTaxAmountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemKey")),
            p => new CombinationQueryPredicate<CartSetCustomLineItemTaxAmountActionQueryBuilderDsl>(p, CartSetCustomLineItemTaxAmountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetCustomLineItemTaxAmountActionQueryBuilderDsl> ExternalTaxAmount(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxAmountDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxAmountDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetCustomLineItemTaxAmountActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxAmount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxAmountDraftQueryBuilderDsl.Of())),
                CartSetCustomLineItemTaxAmountActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartSetCustomLineItemTaxAmountActionQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<CartSetCustomLineItemTaxAmountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<CartSetCustomLineItemTaxAmountActionQueryBuilderDsl>(p, CartSetCustomLineItemTaxAmountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
