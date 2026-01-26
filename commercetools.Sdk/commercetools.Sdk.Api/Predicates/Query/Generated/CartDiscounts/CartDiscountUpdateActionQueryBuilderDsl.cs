using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountUpdateActionQueryBuilderDsl
    {
        public CartDiscountUpdateActionQueryBuilderDsl()
        {
        }

        public static CartDiscountUpdateActionQueryBuilderDsl Of()
        {
            return new CartDiscountUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartDiscountUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(p, CartDiscountUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsAddStore(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountAddStoreActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountAddStoreActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountAddStoreActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsChangeCartPredicate(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeCartPredicateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeCartPredicateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeCartPredicateActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsChangeIsActive(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeIsActiveActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeIsActiveActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeIsActiveActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsChangeName(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeNameActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsChangeRequiresDiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeRequiresDiscountCodeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeRequiresDiscountCodeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeRequiresDiscountCodeActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsChangeSortOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeSortOrderActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeSortOrderActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeSortOrderActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsChangeStackingMode(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeStackingModeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeStackingModeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeStackingModeActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsChangeTarget(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeTargetActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeTargetActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeTargetActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsChangeValue(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeValueActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeValueActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountChangeValueActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsRemoveStore(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountRemoveStoreActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountRemoveStoreActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountRemoveStoreActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetCustomFieldActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetCustomTypeActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetDescriptionActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsSetDiscountGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetDiscountGroupActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetDiscountGroupActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetDiscountGroupActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetKeyActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsSetRecurringOrderScope(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetRecurringOrderScopeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetRecurringOrderScopeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetRecurringOrderScopeActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsSetStores(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetStoresActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetStoresActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetStoresActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsSetValidFrom(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetValidFromActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetValidFromActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetValidFromActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsSetValidFromAndUntil(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetValidFromAndUntilActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetValidFromAndUntilActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetValidFromAndUntilActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl> AsSetValidUntil(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetValidUntilActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetValidUntilActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountSetValidUntilActionQueryBuilderDsl.Of()),
                CartDiscountUpdateActionQueryBuilderDsl.Of);
        }
    }
}
