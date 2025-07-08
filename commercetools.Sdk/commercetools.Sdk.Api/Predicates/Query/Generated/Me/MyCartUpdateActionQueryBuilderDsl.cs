using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartUpdateActionQueryBuilderDsl
    {
        public MyCartUpdateActionQueryBuilderDsl()
        {
        }

        public static MyCartUpdateActionQueryBuilderDsl Of()
        {
            return new MyCartUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(p, MyCartUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsAddDiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartAddDiscountCodeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartAddDiscountCodeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartAddDiscountCodeActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsAddItemShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartAddItemShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartAddItemShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartAddItemShippingAddressActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsAddLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartAddLineItemActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartAddLineItemActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartAddLineItemActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsAddPayment(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartAddPaymentActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartAddPaymentActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartAddPaymentActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsApplyDeltaToLineItemShippingDetailsTargets(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartApplyDeltaToLineItemShippingDetailsTargetsActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsChangeLineItemQuantity(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartChangeLineItemQuantityActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartChangeLineItemQuantityActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartChangeLineItemQuantityActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsChangeLineItemsOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartChangeLineItemsOrderActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartChangeLineItemsOrderActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartChangeLineItemsOrderActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsChangeTaxMode(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartChangeTaxModeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartChangeTaxModeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartChangeTaxModeActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsRecalculate(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartRecalculateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartRecalculateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartRecalculateActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsRemoveDiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartRemoveDiscountCodeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartRemoveDiscountCodeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartRemoveDiscountCodeActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsRemoveItemShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartRemoveItemShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartRemoveItemShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartRemoveItemShippingAddressActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsRemoveLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartRemoveLineItemActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartRemoveLineItemActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartRemoveLineItemActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsRemovePayment(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartRemovePaymentActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartRemovePaymentActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartRemovePaymentActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsSetBillingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetBillingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetBillingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetBillingAddressActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsSetBusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetBusinessUnitActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetBusinessUnitActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetBusinessUnitActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsSetCountry(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetCountryActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetCountryActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetCountryActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetCustomFieldActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsSetCustomLineItemRecurrenceInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetCustomTypeActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsSetCustomerEmail(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetCustomerEmailActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetCustomerEmailActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetCustomerEmailActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsSetDeleteDaysAfterLastModification(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsSetLineItemCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLineItemCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLineItemCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLineItemCustomFieldActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsSetLineItemCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLineItemCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLineItemCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLineItemCustomTypeActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsSetLineItemDistributionChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLineItemDistributionChannelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLineItemDistributionChannelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLineItemDistributionChannelActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsSetLineItemRecurrenceInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsSetLineItemShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLineItemShippingDetailsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLineItemShippingDetailsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLineItemShippingDetailsActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsSetLineItemSupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLineItemSupplyChannelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLineItemSupplyChannelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLineItemSupplyChannelActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsSetLocale(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLocaleActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLocaleActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetLocaleActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsSetShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetShippingAddressActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsSetShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetShippingMethodActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetShippingMethodActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartSetShippingMethodActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl> AsUpdateItemShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartUpdateItemShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartUpdateItemShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartUpdateItemShippingAddressActionQueryBuilderDsl.Of()),
                MyCartUpdateActionQueryBuilderDsl.Of);
        }
    }
}
