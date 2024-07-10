using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class BaseResourceQueryBuilderDsl
    {
        public BaseResourceQueryBuilderDsl()
        {
        }

        public static BaseResourceQueryBuilderDsl Of()
        {
            return new BaseResourceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BaseResourceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<BaseResourceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(p, BaseResourceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseResourceQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<BaseResourceQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(p, BaseResourceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseResourceQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<BaseResourceQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(p, BaseResourceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BaseResourceQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<BaseResourceQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(p, BaseResourceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsApprovalFlow(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsApprovalRule(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsAssociateRole(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsAttributeGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsBusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsCart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsCartDiscount(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsCustomObject(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomObjects.CustomObjectQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomObjects.CustomObjectQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomObjects.CustomObjectQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsCustomer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsCustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsDiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsExtension(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsInventoryEntry(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsMessage(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.MessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.MessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.MessageQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsOrderEdit(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsPayment(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsProduct(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsProductDiscount(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsProductProjection(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsProductSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsProductTailoring(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsProductType(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsQuote(
            Func<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsQuoteRequest(
            Func<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsReview(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsShoppingList(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsStagedQuote(
            Func<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsStandalonePrice(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsStore(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsSubscription(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsTaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsType(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BaseResourceQueryBuilderDsl> AsZone(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BaseResourceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.ZoneQueryBuilderDsl.Of()),
                BaseResourceQueryBuilderDsl.Of);
        }
    }
}
