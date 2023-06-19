using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class StagedOrderUpdateActionQueryBuilderDsl
    {
        public StagedOrderUpdateActionQueryBuilderDsl()
        {
        }

        public static StagedOrderUpdateActionQueryBuilderDsl Of()
        {
            return new StagedOrderUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(p, StagedOrderUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsAddCustomLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddCustomLineItemActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddCustomLineItemActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddCustomLineItemActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsAddDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddDeliveryActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddDeliveryActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddDeliveryActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsAddDiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddDiscountCodeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddDiscountCodeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddDiscountCodeActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsAddItemShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddItemShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddItemShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddItemShippingAddressActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsAddLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddLineItemActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddLineItemActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddLineItemActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsAddParcelToDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddParcelToDeliveryActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddParcelToDeliveryActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddParcelToDeliveryActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsAddPayment(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddPaymentActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddPaymentActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddPaymentActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsAddReturnInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddReturnInfoActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddReturnInfoActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddReturnInfoActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsAddShoppingList(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddShoppingListActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddShoppingListActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderAddShoppingListActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsChangeCustomLineItemMoney(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeCustomLineItemMoneyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeCustomLineItemMoneyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeCustomLineItemMoneyActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsChangeCustomLineItemQuantity(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeCustomLineItemQuantityActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsChangeLineItemQuantity(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeLineItemQuantityActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeLineItemQuantityActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeLineItemQuantityActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsChangeOrderState(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeOrderStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeOrderStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeOrderStateActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsChangePaymentState(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangePaymentStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangePaymentStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangePaymentStateActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsChangeShipmentState(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeShipmentStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeShipmentStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeShipmentStateActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsChangeTaxCalculationMode(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeTaxCalculationModeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeTaxCalculationModeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeTaxCalculationModeActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsChangeTaxMode(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeTaxModeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeTaxModeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeTaxModeActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsChangeTaxRoundingMode(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeTaxRoundingModeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeTaxRoundingModeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderChangeTaxRoundingModeActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsImportCustomLineItemState(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderImportCustomLineItemStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderImportCustomLineItemStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderImportCustomLineItemStateActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsImportLineItemState(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderImportLineItemStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderImportLineItemStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderImportLineItemStateActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsRemoveCustomLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemoveCustomLineItemActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemoveCustomLineItemActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemoveCustomLineItemActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsRemoveDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemoveDeliveryActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemoveDeliveryActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemoveDeliveryActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsRemoveDiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemoveDiscountCodeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemoveDiscountCodeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemoveDiscountCodeActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsRemoveItemShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemoveItemShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemoveItemShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemoveItemShippingAddressActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsRemoveLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemoveLineItemActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemoveLineItemActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemoveLineItemActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsRemoveParcelFromDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsRemovePayment(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemovePaymentActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemovePaymentActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderRemovePaymentActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetBillingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetBillingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetBillingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetBillingAddressActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetBillingAddressCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetBillingAddressCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetBillingAddressCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetBillingAddressCustomFieldActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetBillingAddressCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetBillingAddressCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetBillingAddressCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetBillingAddressCustomTypeActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetCountry(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCountryActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCountryActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCountryActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomFieldActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetCustomLineItemCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomLineItemCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomLineItemCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomLineItemCustomFieldActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetCustomLineItemCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomLineItemCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomLineItemCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomLineItemCustomTypeActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetCustomLineItemShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetCustomLineItemTaxAmount(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomLineItemTaxAmountActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomLineItemTaxAmountActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomLineItemTaxAmountActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetCustomLineItemTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetCustomShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomShippingMethodActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomShippingMethodActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomShippingMethodActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomTypeActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetCustomerEmail(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomerEmailActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomerEmailActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomerEmailActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetCustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomerGroupActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomerGroupActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomerGroupActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetCustomerId(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomerIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomerIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetCustomerIdActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetDeliveryAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetDeliveryAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetDeliveryAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetDeliveryAddressActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetDeliveryAddressCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetDeliveryAddressCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetDeliveryCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetDeliveryCustomFieldActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetDeliveryCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetDeliveryItems(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetDeliveryItemsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetDeliveryItemsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetDeliveryItemsActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetItemShippingAddressCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetItemShippingAddressCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetLineItemCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemCustomFieldActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetLineItemCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemCustomTypeActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetLineItemDistributionChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetLineItemPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemPriceActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemPriceActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemPriceActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetLineItemShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetLineItemTaxAmount(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetLineItemTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemTaxRateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemTaxRateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemTaxRateActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetLineItemTotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetLocale(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLocaleActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLocaleActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetLocaleActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetOrderNumber(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetOrderNumberActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetOrderNumberActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetOrderNumberActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetOrderTotalTax(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetOrderTotalTaxActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetOrderTotalTaxActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetOrderTotalTaxActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetParcelCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetParcelCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetParcelCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetParcelCustomFieldActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetParcelCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetParcelCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetParcelCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetParcelCustomTypeActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetParcelItems(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetParcelItemsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetParcelItemsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetParcelItemsActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetParcelMeasurements(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetParcelMeasurementsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetParcelMeasurementsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetParcelMeasurementsActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetParcelTrackingData(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetParcelTrackingDataActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetParcelTrackingDataActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetParcelTrackingDataActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetPurchaseOrderNumber(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetPurchaseOrderNumberActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetPurchaseOrderNumberActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetPurchaseOrderNumberActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetReturnInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetReturnInfoActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetReturnInfoActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetReturnInfoActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetReturnItemCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetReturnItemCustomFieldActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetReturnItemCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetReturnItemCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetReturnItemCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetReturnItemCustomTypeActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetReturnPaymentState(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetReturnPaymentStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetReturnPaymentStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetReturnPaymentStateActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetReturnShipmentState(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetReturnShipmentStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetReturnShipmentStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetReturnShipmentStateActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingAddressActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetShippingAddressAndCustomShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetShippingAddressAndShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetShippingAddressCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetShippingAddressCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingAddressCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingAddressCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingAddressCustomTypeActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingMethodActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingMethodActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingMethodActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetShippingMethodTaxAmount(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingMethodTaxAmountActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingMethodTaxAmountActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingMethodTaxAmountActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetShippingMethodTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingMethodTaxRateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingMethodTaxRateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingMethodTaxRateActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsSetShippingRateInput(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingRateInputActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingRateInputActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderSetShippingRateInputActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsTransitionCustomLineItemState(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderTransitionCustomLineItemStateActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsTransitionLineItemState(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderTransitionLineItemStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderTransitionLineItemStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderTransitionLineItemStateActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsTransitionState(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderTransitionStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderTransitionStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderTransitionStateActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsUpdateItemShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderUpdateItemShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderUpdateItemShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderUpdateItemShippingAddressActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl> AsUpdateSyncInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderUpdateSyncInfoActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderUpdateSyncInfoActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderUpdateSyncInfoActionQueryBuilderDsl.Of()),
                StagedOrderUpdateActionQueryBuilderDsl.Of);
        }
    }
}
