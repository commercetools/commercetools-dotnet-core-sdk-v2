using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountTargetQueryBuilderDsl
    {
        public CartDiscountTargetQueryBuilderDsl()
        {
        }

        public static CartDiscountTargetQueryBuilderDsl Of()
        {
            return new CartDiscountTargetQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountTargetQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountTargetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountTargetQueryBuilderDsl>(p, CartDiscountTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<CartDiscountTargetQueryBuilderDsl> AsCustomLineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountCustomLineItemsTargetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountCustomLineItemsTargetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountTargetQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountCustomLineItemsTargetQueryBuilderDsl.Of()),
                CartDiscountTargetQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountTargetQueryBuilderDsl> AsLineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountLineItemsTargetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountLineItemsTargetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountTargetQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountLineItemsTargetQueryBuilderDsl.Of()),
                CartDiscountTargetQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountTargetQueryBuilderDsl> AsPattern(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountPatternTargetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountPatternTargetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountTargetQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountPatternTargetQueryBuilderDsl.Of()),
                CartDiscountTargetQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountTargetQueryBuilderDsl> AsShipping(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountShippingCostTargetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountShippingCostTargetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountTargetQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountShippingCostTargetQueryBuilderDsl.Of()),
                CartDiscountTargetQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountTargetQueryBuilderDsl> AsTotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountTotalPriceTargetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountTotalPriceTargetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountTargetQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountTotalPriceTargetQueryBuilderDsl.Of()),
                CartDiscountTargetQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountTargetQueryBuilderDsl> AsMultiBuyCustomLineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.MultiBuyCustomLineItemsTargetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.MultiBuyCustomLineItemsTargetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountTargetQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.MultiBuyCustomLineItemsTargetQueryBuilderDsl.Of()),
                CartDiscountTargetQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountTargetQueryBuilderDsl> AsMultiBuyLineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.MultiBuyLineItemsTargetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.MultiBuyLineItemsTargetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountTargetQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.MultiBuyLineItemsTargetQueryBuilderDsl.Of()),
                CartDiscountTargetQueryBuilderDsl.Of);
        }
    }
}
