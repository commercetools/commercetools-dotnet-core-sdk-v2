using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetCustomLineItemShippingDetailsActionQueryBuilderDsl
    {
        public CartSetCustomLineItemShippingDetailsActionQueryBuilderDsl()
        {
        }

        public static CartSetCustomLineItemShippingDetailsActionQueryBuilderDsl Of()
        {
            return new CartSetCustomLineItemShippingDetailsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetCustomLineItemShippingDetailsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetCustomLineItemShippingDetailsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetCustomLineItemShippingDetailsActionQueryBuilderDsl>(p, CartSetCustomLineItemShippingDetailsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetCustomLineItemShippingDetailsActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<CartSetCustomLineItemShippingDetailsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<CartSetCustomLineItemShippingDetailsActionQueryBuilderDsl>(p, CartSetCustomLineItemShippingDetailsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetCustomLineItemShippingDetailsActionQueryBuilderDsl> ShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetCustomLineItemShippingDetailsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingDetails"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl.Of())),
                CartSetCustomLineItemShippingDetailsActionQueryBuilderDsl.Of);
        }


    }
}
