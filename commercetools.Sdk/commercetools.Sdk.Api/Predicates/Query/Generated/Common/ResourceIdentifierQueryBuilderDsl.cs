using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class ResourceIdentifierQueryBuilderDsl
    {
        public ResourceIdentifierQueryBuilderDsl()
        {
        }

        public static ResourceIdentifierQueryBuilderDsl Of()
        {
            return new ResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<ResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(p, ResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(p, ResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(p, ResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsAssociateRole(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsAttributeGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsBusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsCartDiscount(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsCart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsCustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsCustomer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsDiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsDiscountGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsInventoryEntry(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsOrderEdit(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsPayment(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsProductDiscount(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsProduct(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsProductSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsProductTailoring(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsProductType(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsQuoteRequest(
            Func<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsQuote(
            Func<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsReview(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsShoppingList(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsStagedQuote(
            Func<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsStandalonePrice(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsStore(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsTaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsType(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl> AsZone(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceIdentifierQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.ZoneResourceIdentifierQueryBuilderDsl.Of()),
                ResourceIdentifierQueryBuilderDsl.Of);
        }
    }
}
