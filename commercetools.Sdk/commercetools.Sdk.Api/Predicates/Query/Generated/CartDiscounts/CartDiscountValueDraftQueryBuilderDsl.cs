using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountValueDraftQueryBuilderDsl
    {
        public CartDiscountValueDraftQueryBuilderDsl()
        {
        }

        public static CartDiscountValueDraftQueryBuilderDsl Of()
        {
            return new CartDiscountValueDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountValueDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountValueDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountValueDraftQueryBuilderDsl>(p, CartDiscountValueDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<CartDiscountValueDraftQueryBuilderDsl> AsAbsolute(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueAbsoluteDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueAbsoluteDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountValueDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueAbsoluteDraftQueryBuilderDsl.Of()),
                CartDiscountValueDraftQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountValueDraftQueryBuilderDsl> AsFixed(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueFixedDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueFixedDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountValueDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueFixedDraftQueryBuilderDsl.Of()),
                CartDiscountValueDraftQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountValueDraftQueryBuilderDsl> AsGiftLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueGiftLineItemDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueGiftLineItemDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountValueDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueGiftLineItemDraftQueryBuilderDsl.Of()),
                CartDiscountValueDraftQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountValueDraftQueryBuilderDsl> AsRelative(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueRelativeDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueRelativeDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountValueDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueRelativeDraftQueryBuilderDsl.Of()),
                CartDiscountValueDraftQueryBuilderDsl.Of);
        }
    }
}
