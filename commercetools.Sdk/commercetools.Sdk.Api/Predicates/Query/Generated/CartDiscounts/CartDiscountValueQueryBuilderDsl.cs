using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountValueQueryBuilderDsl
    {
        public CartDiscountValueQueryBuilderDsl()
        {
        }

        public static CartDiscountValueQueryBuilderDsl Of()
        {
            return new CartDiscountValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountValueQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountValueQueryBuilderDsl>(p, CartDiscountValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<CartDiscountValueQueryBuilderDsl> AsAbsolute(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueAbsoluteQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueAbsoluteQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueAbsoluteQueryBuilderDsl.Of()),
                CartDiscountValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountValueQueryBuilderDsl> AsFixed(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueFixedQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueFixedQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueFixedQueryBuilderDsl.Of()),
                CartDiscountValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountValueQueryBuilderDsl> AsGiftLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueGiftLineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueGiftLineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueGiftLineItemQueryBuilderDsl.Of()),
                CartDiscountValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountValueQueryBuilderDsl> AsRelative(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueRelativeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueRelativeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueRelativeQueryBuilderDsl.Of()),
                CartDiscountValueQueryBuilderDsl.Of);
        }
    }
}
