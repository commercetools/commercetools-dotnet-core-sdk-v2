using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartUpdateActionQueryBuilderDsl
    {
        public CartUpdateActionQueryBuilderDsl()
        {
        }

        public static CartUpdateActionQueryBuilderDsl Of()
        {
            return new CartUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(p, CartUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsAddCustomLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartAddCustomLineItemActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartAddCustomLineItemActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartAddCustomLineItemActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsAddCustomShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartAddCustomShippingMethodActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartAddCustomShippingMethodActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartAddCustomShippingMethodActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsAddDiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartAddDiscountCodeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartAddDiscountCodeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartAddDiscountCodeActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsAddItemShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartAddItemShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartAddItemShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartAddItemShippingAddressActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsAddLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartAddLineItemActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartAddLineItemActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartAddLineItemActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsAddPayment(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartAddPaymentActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartAddPaymentActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartAddPaymentActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsAddShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartAddShippingMethodActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartAddShippingMethodActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartAddShippingMethodActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsAddShoppingList(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartAddShoppingListActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartAddShoppingListActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartAddShoppingListActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsApplyDeltaToCustomLineItemShippingDetailsTargets(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartApplyDeltaToCustomLineItemShippingDetailsTargetsActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsApplyDeltaToLineItemShippingDetailsTargets(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsChangeCustomLineItemMoney(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeCustomLineItemMoneyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeCustomLineItemMoneyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeCustomLineItemMoneyActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsChangeCustomLineItemPriceMode(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeCustomLineItemPriceModeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeCustomLineItemPriceModeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeCustomLineItemPriceModeActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsChangeCustomLineItemQuantity(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeCustomLineItemQuantityActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeCustomLineItemQuantityActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeCustomLineItemQuantityActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsChangeLineItemQuantity(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeLineItemQuantityActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeLineItemQuantityActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeLineItemQuantityActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsChangeLineItemsOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeLineItemsOrderActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeLineItemsOrderActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeLineItemsOrderActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsChangePriceRoundingMode(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartChangePriceRoundingModeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartChangePriceRoundingModeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartChangePriceRoundingModeActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsChangeTaxCalculationMode(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeTaxCalculationModeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeTaxCalculationModeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeTaxCalculationModeActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsChangeTaxMode(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeTaxModeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeTaxModeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeTaxModeActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsChangeTaxRoundingMode(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeTaxRoundingModeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeTaxRoundingModeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartChangeTaxRoundingModeActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsFreezeCart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartFreezeCartActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartFreezeCartActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartFreezeCartActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsLockCart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartLockCartActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartLockCartActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartLockCartActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsRecalculate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartRecalculateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartRecalculateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartRecalculateActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsRemoveCustomLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartRemoveCustomLineItemActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartRemoveCustomLineItemActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartRemoveCustomLineItemActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsRemoveDiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartRemoveDiscountCodeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartRemoveDiscountCodeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartRemoveDiscountCodeActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsRemoveItemShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartRemoveItemShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartRemoveItemShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartRemoveItemShippingAddressActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsRemoveLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartRemoveLineItemActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartRemoveLineItemActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartRemoveLineItemActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsRemovePayment(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartRemovePaymentActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartRemovePaymentActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartRemovePaymentActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsRemoveShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartRemoveShippingMethodActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartRemoveShippingMethodActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartRemoveShippingMethodActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetAnonymousId(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetAnonymousIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetAnonymousIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetAnonymousIdActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetBillingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetBillingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetBillingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetBillingAddressActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetBillingAddressCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetBillingAddressCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetBillingAddressCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetBillingAddressCustomFieldActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetBillingAddressCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetBillingAddressCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetBillingAddressCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetBillingAddressCustomTypeActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetBusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetBusinessUnitActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetBusinessUnitActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetBusinessUnitActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetCartTotalTax(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCartTotalTaxActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCartTotalTaxActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCartTotalTaxActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetCountry(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCountryActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCountryActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCountryActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomFieldActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetCustomLineItemCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomLineItemCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomLineItemCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomLineItemCustomFieldActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetCustomLineItemCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomLineItemCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomLineItemCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomLineItemCustomTypeActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetCustomLineItemRecurrenceInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetCustomLineItemShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomLineItemShippingDetailsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomLineItemShippingDetailsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomLineItemShippingDetailsActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetCustomLineItemTaxAmount(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomLineItemTaxAmountActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomLineItemTaxAmountActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomLineItemTaxAmountActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetCustomLineItemTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomLineItemTaxRateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomLineItemTaxRateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomLineItemTaxRateActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetCustomShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomShippingMethodActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomShippingMethodActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomShippingMethodActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomTypeActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetCustomerEmail(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomerEmailActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomerEmailActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomerEmailActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetCustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomerGroupActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomerGroupActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomerGroupActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetCustomerId(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomerIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomerIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetCustomerIdActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetDeleteDaysAfterLastModification(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetDirectDiscounts(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetDirectDiscountsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetDirectDiscountsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetDirectDiscountsActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetItemShippingAddressCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetItemShippingAddressCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetItemShippingAddressCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetItemShippingAddressCustomFieldActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetItemShippingAddressCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetKeyActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetLineItemCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemCustomFieldActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetLineItemCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemCustomTypeActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetLineItemDistributionChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemDistributionChannelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemDistributionChannelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemDistributionChannelActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetLineItemInventoryMode(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemInventoryModeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemInventoryModeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemInventoryModeActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetLineItemPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemPriceActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemPriceActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemPriceActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetLineItemRecurrenceInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemRecurrenceInfoActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemRecurrenceInfoActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemRecurrenceInfoActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetLineItemShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemShippingDetailsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemShippingDetailsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemShippingDetailsActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetLineItemSupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemSupplyChannelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemSupplyChannelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemSupplyChannelActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetLineItemTaxAmount(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemTaxAmountActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemTaxAmountActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemTaxAmountActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetLineItemTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemTaxRateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemTaxRateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemTaxRateActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetLineItemTotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemTotalPriceActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemTotalPriceActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLineItemTotalPriceActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetLocale(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLocaleActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLocaleActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetLocaleActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetPurchaseOrderNumber(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetPurchaseOrderNumberActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetPurchaseOrderNumberActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetPurchaseOrderNumberActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingAddressActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetShippingAddressCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingAddressCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingAddressCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingAddressCustomFieldActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetShippingAddressCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingAddressCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingAddressCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingAddressCustomTypeActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetShippingCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingCustomFieldActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetShippingCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingCustomTypeActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingMethodActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingMethodActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingMethodActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetShippingMethodTaxAmount(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingMethodTaxAmountActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingMethodTaxAmountActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingMethodTaxAmountActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetShippingMethodTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingMethodTaxRateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingMethodTaxRateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingMethodTaxRateActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsSetShippingRateInput(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingRateInputActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingRateInputActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartSetShippingRateInputActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsUnfreezeCart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartUnfreezeCartActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartUnfreezeCartActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartUnfreezeCartActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsUnlockCart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartUnlockCartActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartUnlockCartActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartUnlockCartActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl> AsUpdateItemShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartUpdateItemShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartUpdateItemShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartUpdateItemShippingAddressActionQueryBuilderDsl.Of()),
                CartUpdateActionQueryBuilderDsl.Of);
        }
    }
}
