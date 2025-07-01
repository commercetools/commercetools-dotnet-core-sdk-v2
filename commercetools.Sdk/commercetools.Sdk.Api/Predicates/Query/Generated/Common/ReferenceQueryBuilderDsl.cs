using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class ReferenceQueryBuilderDsl
    {
        public ReferenceQueryBuilderDsl()
        {
        }

        public static ReferenceQueryBuilderDsl Of()
        {
            return new ReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<ReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(p, ReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(p, ReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsAssociateRole(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsAttributeGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsBusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsCartDiscount(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsCart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsKeyValueDocument(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomObjects.CustomObjectReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomObjects.CustomObjectReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomObjects.CustomObjectReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsCustomerEmailToken(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerEmailTokenReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerEmailTokenReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerEmailTokenReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsCustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsCustomerPasswordToken(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerPasswordTokenReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerPasswordTokenReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerPasswordTokenReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsCustomer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsDirectDiscount(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsDiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsDiscountGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsInventoryEntry(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsOrderEdit(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsPaymentMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsPayment(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsProductDiscount(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsProduct(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsProductSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsProductTailoring(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsProductType(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsQuote(
            Func<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsQuoteRequest(
            Func<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsReview(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsShoppingList(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsStagedQuote(
            Func<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsStandalonePrice(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsStore(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsTaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsType(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReferenceQueryBuilderDsl> AsZone(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.ZoneReferenceQueryBuilderDsl.Of()),
                ReferenceQueryBuilderDsl.Of);
        }
    }
}
