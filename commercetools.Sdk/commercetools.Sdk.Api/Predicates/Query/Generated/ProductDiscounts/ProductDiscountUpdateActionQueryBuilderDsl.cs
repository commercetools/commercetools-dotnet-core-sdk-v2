using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountUpdateActionQueryBuilderDsl
    {
        public ProductDiscountUpdateActionQueryBuilderDsl()
        {
        }

        public static ProductDiscountUpdateActionQueryBuilderDsl Of()
        {
            return new ProductDiscountUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductDiscountUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl>(p, ProductDiscountUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl> AsChangeIsActive(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountChangeIsActiveActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountChangeIsActiveActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountChangeIsActiveActionQueryBuilderDsl.Of()),
                ProductDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl> AsChangeName(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountChangeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountChangeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountChangeNameActionQueryBuilderDsl.Of()),
                ProductDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl> AsChangePredicate(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountChangePredicateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountChangePredicateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountChangePredicateActionQueryBuilderDsl.Of()),
                ProductDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl> AsChangeSortOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountChangeSortOrderActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountChangeSortOrderActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountChangeSortOrderActionQueryBuilderDsl.Of()),
                ProductDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl> AsChangeValue(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountChangeValueActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountChangeValueActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountChangeValueActionQueryBuilderDsl.Of()),
                ProductDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountSetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountSetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountSetDescriptionActionQueryBuilderDsl.Of()),
                ProductDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountSetKeyActionQueryBuilderDsl.Of()),
                ProductDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl> AsSetValidFrom(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountSetValidFromActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountSetValidFromActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountSetValidFromActionQueryBuilderDsl.Of()),
                ProductDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl> AsSetValidFromAndUntil(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl.Of()),
                ProductDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl> AsSetValidUntil(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountSetValidUntilActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountSetValidUntilActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountSetValidUntilActionQueryBuilderDsl.Of()),
                ProductDiscountUpdateActionQueryBuilderDsl.Of);
        }
    }
}
